using System;
using System.Windows.Forms;

namespace DelegateMethod
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			btnClick.Click += delegate (object sender, EventArgs e)
			{
				MessageBox.Show("Olá, fui clicado! Com parâmetros.");
			};

			btnClick.Click += delegate
			{
				MessageBox.Show("Olá, fui clicado! Sem parâmetros.");
			};
		}
	}
}
