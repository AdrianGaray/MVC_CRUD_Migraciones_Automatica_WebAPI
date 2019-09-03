using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MVC_CRUD_Migraciones_Automatica_WebAPI.Models;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Controllers
{
    public class OrdersAPIController : ApiController
    {
        private MVC_CRUD_Migraciones_Automatica_WebAPIContext db = new MVC_CRUD_Migraciones_Automatica_WebAPIContext();

        // GET: api/OrdersAPI
        public IHttpActionResult GetOrders() // se moficio el retorno de IQueryable<Order> por IHttpActionResult, para q sea mas dinamico
        {
            var orders = db.Orders.ToList(); // tiene las ordenes q estan en la base de datos
            var ordersAPI = new List<OrderAPI>(); // se crea el objeto de respuesta

            foreach (var order in orders)
            {
                var orderAPI = new OrderAPI()
                {
                    Customer = order.Customer,
                    DateOrder = order.DateOrder,
                    Details = order.OrderDetails,
                    OrderID = order.OrderID,
                    OrderStatus = order.OrderStatus
                };
                ordersAPI.Add(orderAPI);
            }

            return Ok(ordersAPI); // es un metodo heredado de ApiController
        }

        // GET: api/OrdersAPI/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // PUT: api/OrdersAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderID)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/OrdersAPI
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderID }, order);
        }

        // DELETE: api/OrdersAPI/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult DeleteOrder(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            db.SaveChanges();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return db.Orders.Count(e => e.OrderID == id) > 0;
        }
    }
}