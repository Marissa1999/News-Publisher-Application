using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherApplication
{
    class Client
    {
        public static void Main(string[] args)
        {

            NewsPublisher mainPublisher = new NewsPublisher();
        
            NewsReader reader1 = new NewsReader(23473);
            NewsReader reader2 = new NewsReader(13748);
            NewsReader reader3 = new NewsReader(94934);
            NewsReader reader4 = new NewsReader(32858);
            NewsReader reader5 = new NewsReader(23428);
            NewsReader reader6 = new NewsReader(59685);
            NewsReader reader7 = new NewsReader(49359);
            NewsReader reader8 = new NewsReader(94353);
            NewsReader reader9 = new NewsReader(12364);
            NewsReader reader10 = new NewsReader(47583);

            mainPublisher.Register(reader1);
            mainPublisher.Register(reader2);
            mainPublisher.Register(reader3);
            mainPublisher.Register(reader4);
            mainPublisher.Register(reader5);
            mainPublisher.Register(reader6);
            mainPublisher.Register(reader7);
            mainPublisher.Register(reader8);
            mainPublisher.Register(reader9);
            mainPublisher.Register(reader10);

            mainPublisher.SetNewsArticle("954 - College Computer Science Grads Lack Skills/Experience");
            reader1.ReadNews();
            reader4.ReadNews();
            reader6.ReadNews();
            reader9.ReadNews();
            reader10.ReadNews();

            mainPublisher.SetNewsArticle("222 - Software Updates Slowing You Down?");
            reader2.ReadNews();
            reader3.ReadNews();
            reader5.ReadNews();
            reader7.ReadNews();
            reader8.ReadNews();

            mainPublisher.UnRegister(reader1);
            mainPublisher.UnRegister(reader2);
            mainPublisher.UnRegister(reader3);
           
            mainPublisher.SetNewsArticle("472 - Amazon Recognizes Computer Science Teachers");

        }
    }
}
