using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WCFDemoSvcGUICli
{
    public class ClientMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            return;
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            IExtensionCollection<IContextChannel> contexts = channel.Extensions;
            CollectionChannelExtension cce = channel.Extensions.Find<CollectionChannelExtension>();
            if (cce==null)
            {
                cce = new CollectionChannelExtension();
                channel.Extensions.Add(cce);
            }
            int x = channel.Extensions.Count();
            return null;
        }
    }
}
