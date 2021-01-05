using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherApplication
{
    class NewsReader : INewsReader
    {

        public int NewsReaderNumber { get; set; }

        public NewsReader(int number)
        {
            NewsReaderNumber = number;
        }

        public void ReadNews()
        {        
            Console.WriteLine($"NewsReader {NewsReaderNumber} read the news: {NewsPublisher.NewsArticle}");
            Console.WriteLine();
        }

    }
}
