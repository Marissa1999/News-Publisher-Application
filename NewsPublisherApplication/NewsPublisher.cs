using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherApplication
{
    class NewsPublisher : INewsPublisher
    {

        public List<NewsReader> NewsReaderList = new List<NewsReader>();

        public static string NewsArticle { get; set; }

        public void NotifyNewsReader()
        {
            foreach(NewsReader member in NewsReaderList)
            {
                Console.WriteLine($"Message for: {member.NewsReaderNumber} [NewsPublisher - A New Article is Published: {NewsArticle}]");
            }

            Console.WriteLine();
        }

        public void Register(NewsReader newMember)
        {
            NewsReaderList.Add(newMember);
        }


        public void SetNewsArticle(string articleText)
        {
            NewsArticle = articleText;
            NotifyNewsReader();
        }

        public void UnRegister(NewsReader existingMember)
        {
            NewsReaderList.Remove(existingMember);
        }

    }
}
