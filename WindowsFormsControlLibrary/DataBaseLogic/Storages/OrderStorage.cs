using DataBaseLogic.BindingModels;
using DataBaseLogic.Models;
using DataBaseLogic.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLogic.Storages
{
    public class OrderStorage
    {
        public void Delete(OrderBindingModel model)
        {
            using var context = new InternetShopDatabase();
            var element = context.Orders
                .FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                context.Orders.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public OrderViewModel GetElement(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new InternetShopDatabase();
            var order = context.Orders
                .Include(rec => rec.Products)
                .FirstOrDefault(rec => rec.Id == model.Id);
            return order != null ? CreateModel(order) : null;
        }

        public List<OrderViewModel> GetFilteredList(OrderBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new InternetShopDatabase();
            return context.Orders
                .Include(rec => rec.Products)
                .Where(rec => rec.Id.Equals(model.Id))
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public List<OrderViewModel> GetFullList()
        {
            using var context = new InternetShopDatabase();
            return context.Orders
                .Include(rec => rec.Products)
                .ToList()
                .Select(CreateModel)
                .ToList();
        }

        public void Insert(OrderBindingModel model)
        {
            using var context = new InternetShopDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                context.Orders.Add(CreateModel(model, new Order()));
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        public void Update(OrderBindingModel model)
        {
            using var context = new InternetShopDatabase();
            using var transaction = context.Database.BeginTransaction();
            try
            {
                var element = context.Orders
                    .FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private static Order CreateModel(OrderBindingModel model, Order order)
        {
            order.CustomerFIO = model.CustomerFIO;
            order.Image = model.Image;
            order.Mail = model.Mail;
            return order;
        }

        private static OrderViewModel CreateModel(Order order)
        {
            return new OrderViewModel
            {
                Id = order.Id,
                CustomerFIO = order.CustomerFIO,
                Image = order.Image,
                Mail = order.Mail,
                Products = order.Products
                    .ToDictionary(rec => rec.Name,
                    rec => rec.Id)
            };
        }
    }
}
