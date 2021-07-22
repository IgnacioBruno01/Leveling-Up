using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
	class Items
	{
		public string name;
		public int price;
		protected string description;

		public Items(string name, int price, string description)
		{
			this.name = name;
			this.price = price;
			this.description = description;
		}
	}

	abstract class Consumables : Items
	{
		int _quantity;
		public Consumables(string name, int price, string description, int quantity) : base(name, price, description)
		{
			_quantity = quantity;
		}
	}

	abstract class Potion : Consumables
	{
		int _quantity;
		public Potion(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	sealed class HealerPotion : Potion
	{
		int _quantity;
		public HealerPotion(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	sealed class ManaPotion : Potion
	{
		int _quantity;
		public ManaPotion(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	sealed class AntidotePotion : Potion
	{
		int _quantity;
		public AntidotePotion(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	sealed class Arrow : Consumables
	{
		int _quantity;
		public Arrow(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	sealed class MetalArrow : Consumables
	{
		int _quantity;
		public MetalArrow(string name, int price, string description, int quantity) : base(name, price, description, quantity)
		{
			_quantity = quantity;
		}
	}
	abstract class Equipment : Items
	{
		public Equipment(string name, int price, string description) : base(name, price, description)
		{

		}
	}
	abstract class Armadura : Equipment
	{
		public int _defense;
		public Armadura(string name, int price, string description, int defense) : base(name, price, description)
		{
			_defense = defense;
		}
	}
	sealed class armaduraCuero : Armadura
	{

		public armaduraCuero(string name, int price, string description, int defense) : base(name, price, description, defense)
		{
		}
	}
	sealed class armaduraPlaca : Armadura
	{

		public armaduraPlaca(string name, int price, string description, int defense) : base(name, price, description, defense)
		{
		}
	}
	abstract class Shield : Equipment
	{
		public int _defense;
		public Shield(string name, int price, string description, int defense) : base(name, price, description)
		{
			_defense = defense;
		}
	}
	abstract class Armas : Equipment
	{
		public int _Damage;
		public Armas(string name, int price, string description, int Damage) : base(name, price, description)
		{
			_Damage = Damage;
		}
	}
	abstract class Sword : Equipment
	{
		public int _Damage;
		public Sword(string name, int price, string description, int Damage) : base(name, price, description)
		{
			_Damage = Damage;
		}
	}
	abstract class Lance : Equipment
	{
		public int _Damage;
		public Lance(string name, int price, string description, int Damage) : base(name, price, description)
		{
			_Damage = Damage;
		}
	}
	abstract class Bow : Equipment
	{
		public int _Damage;
		public Bow(string name, int price, string description, int Damage) : base(name, price, description)
		{
			_Damage = Damage;
		}
	}
	abstract class Dagger : Equipment
	{
		public int _Damage;
		public Dagger(string name, int price, string description, int Damage) : base(name, price, description)
		{
			_Damage = Damage;
		}
	}
	abstract class Acessories : Equipment
	{
		public Acessories(string name, int price, string description) : base(name, price, description)
		{
		}
	}
	abstract class Ring : Acessories
	{
		public Ring(string name, int price, string description) : base(name, price, description)
		{
		}
	}
	abstract class Necklaces : Acessories
	{
		public Necklaces(string name, int price, string description) : base(name, price, description)
		{
		}
	}
}