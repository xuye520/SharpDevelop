//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;	
using System.Data.Common;
using System.Data.OleDb;

/// <summary>
/// This class handles the connection to a DataBase 
/// </summary>
/// <remarks>
/// 	created by - Forstmeier Peter
/// 	created on - 17.10.2005 22:59:39
/// </remarks>

namespace SharpReportCore {
	public class ConnectionObject : object,IDisposable {
		IDbConnection connection;
		OleDbConnectionStringBuilder oleDbConnectionStringBuilder;
		string connectionString;
		
		
		public ConnectionObject(string connectionString) {
			if (String.IsNullOrEmpty(connectionString)) {
				throw new ArgumentNullException("connectionString");
			}
			this.connectionString = connectionString;
			this.connection = new OleDbConnection (this.connectionString);
		}
		
		public ConnectionObject( OleDbConnectionStringBuilder oleDbConnectionStringBuilder){
			this.oleDbConnectionStringBuilder = oleDbConnectionStringBuilder;
			try {
				this.connection = new OleDbConnection (this.oleDbConnectionStringBuilder.ConnectionString);
			} catch (Exception ) {
				throw;
			}
		}
		
		public ConnectionObject(IDbConnection connection){
			this.connection = connection;
			this.connectionString = this.connection.ConnectionString;
		}
		
		public IDbConnection Connection {
			get {
				return connection;
			}
			
		}
		
		public void Dispose(){
			if (this.connection != null) {
				if (this.connection.State == ConnectionState.Open) {
					this.connection.Close();
				}
				this.connection.Dispose();
			}
		}
		
	}
}
