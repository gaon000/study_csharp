using System;
using System.Collections.Generic;

namespace NestedClass
{
    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string Item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, Item, value);
        }

        public string GetConfig(string item)
        {
            foreach (ItemValue iv in listConfig)
            {
                if (iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }

        private class ItemValue
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for (int i = 0; i < config.listConfig.Count; i++) // 중첩 클래스는 상위 클래스의 멤버에 자유롭게 접근할 수 있다.
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem()
            {
                return item;
            }
            public string GetValue()
            {
                return value;
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V  5.0");
            config.SetConfig("Size", "655,322 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");
            Console.WriteLine(config.GetConfig("Version"));


        }
    }
}