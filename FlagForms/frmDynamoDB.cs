using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.DynamoDB
{
    public partial class frmDynamoDB : Form
    {
        public frmDynamoDB()
        {
            InitializeComponent();
        }

        private QueryRequest _queryRequest;

        private async void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            List<Task> queryTasks = new List<Task>();

            using (AmazonDynamoDBClient client = new AmazonDynamoDBClient(Amazon.RegionEndpoint.EUWest2))
            {
                while (i < 100)
                {
                    while (j < 1000)
                    {
                        Task queryResultsTask = Task.Run(async () =>
                        {
                            try
                            {
                                await client.QueryAsync(_queryRequest);

                                Debug.Print($"{i}");

                            }
                            catch (Exception ex)
                            {
                                Debug.Print(ex.Message);
                            }
                        
                        });

                        queryTasks.Add(queryResultsTask);
                        j++;
                    }

                    await Task.WhenAll(queryTasks.ToArray());

                    queryTasks.Clear();

                    j = 0;

                    i++;
                }
            }
        }

        private async void Sequential_Click(object sender, EventArgs e)
        {
            int k = 0;

            using (AmazonDynamoDBClient client = new AmazonDynamoDBClient(Amazon.RegionEndpoint.EUWest2))
            {
                while (k < 1000)
                {
                    Task queryResultsTask = Task.Run(async () =>
                    {
                        try
                        {
                            await client.QueryAsync(_queryRequest);
                            Debug.Print($"{k}");
                        }
                        catch (Exception ex)
                        {
                            Debug.Print(ex.Message);
                        }
                    });

                    await queryResultsTask;
                    k++;
                }
            }
        }

        private void frmDynamoDB_Load(object sender, EventArgs e)
        {
            _queryRequest = new QueryRequest
            {
                TableName = "Movies",
                ExpressionAttributeNames = new Dictionary<string, string>
        {
          { "#yr", "year" }
        },
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
        {
          { ":qYr",   new AttributeValue { N = "1992" } },
          { ":tSt",   new AttributeValue { S = "M" } },
          { ":tEn",   new AttributeValue { S = "Tzz" } }
        },
                KeyConditionExpression = "#yr = :qYr and title between :tSt and :tEn",
                ProjectionExpression = "#yr, title, info.actors[0], info.genres, info.running_time_secs"
            };
        }
    }
}
