using Innvoice_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Http.Formatting;

namespace Innvoice_Services.Controllers
{
  
    public class ValuesController : ApiController
    {
        SqlConnection conn = new SqlConnection( ConfigurationManager.ConnectionStrings["webapi_conn"].ConnectionString);
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            List<Invoice> resultList = new List<Invoice>();
            string query = @"
            SELECT DISTINCT
                i.InvoiceNo AS InvoiceNo,
                i.DateInvoiced AS InvoiceDate,
                j.dateininventory AS OrderDate,
                j.datefreetimeexpires AS SONumber,
                j.stevedore AS OrderedBy,
                t.barge AS CustomerPONumber,
                t.customer AS CustomerNo,
                t.loading_unloading_ch AS PaymentMethod,
                t.cargo AS Warehouse,
                t.hatch AS FOB,
                t.bill_of_lading AS SalesPerson,
                t.lot_identifer AS ResaleNumber,
                t.heigth AS OrderQuantity,
                t.length AS ShipQuantity,
                t.destination AS Tax,
                t.bookingno AS ItemNumber,
                t.metrictons AS UnitPrice,
                t.shipper AS ShipVia
            FROM job j
            LEFT JOIN transactions t ON j.jobid = t.jobno
            LEFT JOIN Invoice i ON j.jobid = i.jobidREF
            WHERE j.jobid = @JobId;";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@JobId", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                // Procesar los resultados del lector
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Acceder a las columnas de las tablas (reader["NombreColumna"])
                        // Construir objetos o estructuras de datos según tus necesidades
                        // Puedes devolver los resultados como un objeto anónimo o mapearlos a una clase
                        var result = new Invoice(
                            reader["InvoiceNo"] != DBNull.Value ? reader["InvoiceNo"].ToString() : null,
                reader["CustomerNo"] != DBNull.Value ? reader["CustomerNo"].ToString() : null,
               reader["InvoiceDate"] != DBNull.Value ? (DateTime?)reader.GetDateTime(reader.GetOrdinal("InvoiceDate")) : null,
               reader["OrderDate"] != DBNull.Value ? reader["OrderDate"].ToString() : null,
                 reader["SONumber"] != DBNull.Value ? reader["SONumber"].ToString() : null,
              reader["OrderedBy"] != DBNull.Value ? reader["OrderedBy"].ToString() : null,
                 reader["CustomerPONumber"] != DBNull.Value ? reader["CustomerPONumber"].ToString() : null,
                reader["PaymentMethod"] != DBNull.Value ? reader["PaymentMethod"].ToString() : null,
              reader["Warehouse"] != DBNull.Value ? reader["Warehouse"].ToString() : null,
              reader["FOB"] != DBNull.Value ? reader["FOB"].ToString() : null,
                 reader["SalesPerson"] != DBNull.Value ? reader["SalesPerson"].ToString() : null,
                 reader["ResaleNumber"] != DBNull.Value ? reader["ResaleNumber"].ToString() : null,
               reader["OrderQuantity"] != DBNull.Value ? (float?)reader["OrderQuantity"] : null,
                                reader["ShipQuantity"] != DBNull.Value ? (float?)reader["ShipQuantity"] : null,
                            reader["Tax"] != DBNull.Value ? reader["Tax"].ToString() : null,
                            reader["ItemNumber"] != DBNull.Value ? reader["ItemNumber"].ToString() : null,
                            
                             reader["UnitPrice"] != DBNull.Value ? (Double?)reader["UnitPrice"] : null,
                            reader["UnitPrice"] != DBNull.Value ? (Double?)reader["UnitPrice"]*100  : null,
                             reader["ShipVia"] != DBNull.Value ? reader["ShipVia"].ToString() : null



                            );
                        resultList.Add(result);

                        // Hacer algo con 'result', como devolverlo en la respuesta
                      
                    }
                }

                conn.Close();
                
            }
            if (resultList.Any())
            {
              return  Content(System.Net.HttpStatusCode.OK, resultList, new JsonMediaTypeFormatter(), "application/json");
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
