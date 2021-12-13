using CoreDeneme.Abstract;
using CoreDeneme.Model;
using DotNetCore.CAP;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDeneme.RabbitMqService
{
    public class PublisherManager : IPublisherService
    {
        private readonly IRabbitMqService _rabbitMQServices;
        private readonly IObjectConvertFormat _objectConvertFormat;
        private readonly ICapPublisher _capPublisher;
        private dynamic _channel;
        private dynamic _connection;
        private readonly ApplicationDbContext _dbContext;
        public PublisherManager(IRabbitMqService rabbitMQServices, IObjectConvertFormat objectConvertFormat, ICapPublisher capPublisher, ApplicationDbContext dbContext)
        {
            _rabbitMQServices = rabbitMQServices;
            _objectConvertFormat = objectConvertFormat;
            _capPublisher = capPublisher;
            _dbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queueDataModels">Herhangi bir tipte gönderilebilir where koşullaırına uyan</param>
        /// <param name="queueName">Queue kuyrukta hangi isimde tutulacağı bilgisi operasyon istek zamanı gönderilebilir.</param>
        public  async Task Enqueue<T>(IEnumerable<T> queueDataModels, string queueName) where T : class
        {
            try
            {

                //_connection = _rabbitMQServices.GetConnection();
                //using (IModel _channel = _rabbitMQServices.GetModel(_connection))
                //{
                //    _channel.QueueDeclare(queue: queueName,
                //                         durable: true,      // ile in-memory mi yoksa fiziksel olarak mı saklanacağı belirlenir.
                //                         exclusive: false,   // yalnızca bir bağlantı tarafından kullanılır ve bu bağlantı kapandığında sıra silinir - özel olarak işaretlenirse silinmez
                //                         autoDelete: false,  // en son bir abonelik iptal edildiğinde en az bir müşteriye sahip olan kuyruk silinir
                //                         arguments: null);   // isteğe bağlı; eklentiler tarafından kullanılır ve TTL mesajı, kuyruk uzunluğu sınırı, vb. 





                //}
                //var body = Encoding.UTF8.GetBytes(_objectConvertFormat.ObjectToJson(queueDataModel));
                //_channel.BasicPublish(exchange: "",
                //                     routingKey: queueName,
                //                     mandatory: false,
                //                     body: body);

                for (int i = 0; i < 3; i++)
                {
                    using var transaction = _dbContext.Database.BeginTransaction(_capPublisher, autoCommit: true);

                    await _capPublisher.PublishAsync<string>("producer.transaction2", "aliveli");

                }


            }
            catch (Exception ex)
            {
                //loglama yapılabilir
                throw new Exception(ex.InnerException.Message.ToString());
            }
        }
    }
}
