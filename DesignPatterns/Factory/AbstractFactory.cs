using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
	public class NavigationBar
	{
		public NavigationBar(IUIFactory factory) => factory.CreateButton();
	}

	public class DropdownMenu
	{
		public DropdownMenu(IUIFactory factory) => factory.CreateButton();
	}

	public interface IUIFactory
	{
		public Button CreateButton();
	}

	public class Apple : IUIFactory
	{
		public Button CreateButton()
		{
			return new Button { Type = "iOS Button"};
		}
	}

	public class Android : IUIFactory
	{
		public Button CreateButton()
		{
			return new Button { Type = "Android Button"};
		}
	}

	public class Button
	{
		public string Type { get; set; }
	}
}
