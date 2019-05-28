Set-StrictMode -Version 2.0
$ErrorActionPreference = 'Stop'

function ExecuteSqlQuery ($Server, $Database, $SQLQuery) {
	
	$Datatable = New-Object System.Data.DataTable
	
	$Connection = New-Object System.Data.SQLClient.SQLConnection
	$Connection.ConnectionString = "server='$Server';database='$Database';User ID=sapphire_cat;Password=P@ssw0rd.1"
	Write-Host "Connecting to : $($Connection.ConnectionString)"
	$Connection.Open()
	$Command = New-Object System.Data.SQLClient.SQLCommand
	$Command.Connection = $Connection
	$Command.CommandText = $SQLQuery
	$Reader = $Command.ExecuteReader()
	$Datatable.Load($Reader)
	Write-Host "Data rows found: $($Datatable.Rows.Count)"
	$Connection.Close()
	
	return $Datatable
}

$count = ExecuteSQLQuery "tcp:sapphirecat.database.windows.net,1433" "Flags" "SELECT ID,ImageFile From Flags"

$count | % {
    
    "copy Flags\$($_.ImageFile).png FlagsGuid\$($_.ID).png"

}