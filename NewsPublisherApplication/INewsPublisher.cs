using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublisherApplication
{
    interface INewsPublisher
    {
        void Register(NewsReader newMember);

        void UnRegister(NewsReader existingMember);

        void SetNewsArticle(string articleText);

        void NotifyNewsReader();
    }
}
