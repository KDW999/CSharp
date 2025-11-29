using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }
    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    internal class Program
    {
        static List<Item> _items = new List<Item>();
        delegate bool ItemSelector(Item item);
        delegate Return MyFunc<T, Return>(T item); // delegate로 generic 가능

        //static bool IsWeapon(Item item)
        //{
        //    return item.ItemType == ItemType.Weapon;
        //}

        //static Item FindItem(MyFunc<Item, bool> selector)
        //{
        //    return null;
        //}
        //static Item FindItem(Func<Item, bool> selector)
        //{
        //    return null;
        //}
        static Item FindItem(ItemSelector selector)
        {
            foreach (Item item in _items)
            {
                if (selector(item))
                {
                    return item;
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없으면 Action

            ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });
            // Lambda : 일회용 함수를 만드는데 사용하는 문법

            //Item item = FindItem(IsWeapon);

            // Anonymous Function : 무명 함수 / 익명함수
            //Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });

            // Lambda (왼쪽의 인자를 받아서 오른쪽 값을 실행하는 느낌)
            // 함수를 하나하나 만드는 것 보단 한 번만 쓸 함수를 빠르게 실행하기 위함
            Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });
            //Item item = FindItem(selector);
        }
    }
}
