using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFDemoSvcGUICli
{
    public class CollectionChannelExtension : IExtension<IContextChannel>
    {
        private readonly Dictionary<string, object> _items = new Dictionary<string, object>();

        public T Get<T>(string key)
        {
            object obj;
            if (!this._items.TryGetValue(key, out obj))
            {
                obj = default(T);
            }
            return (T)((object)obj);
        }

        public void Add(string key, object value)
        {
            this._items[key] = value;
        }

        public void Remove(string key)
        {
            this._items.Remove(key);
        }

        public void Clear()
        {
            this._items.Clear();
        }

        void IExtension<IContextChannel>.Attach(IContextChannel owner)
        {
        }

        void IExtension<IContextChannel>.Detach(IContextChannel owner)
        {
        }
    }
}
