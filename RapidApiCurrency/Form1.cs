﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapid_Api_Currency
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		decimal dollar = 0;
		decimal euro = 0;
		decimal pound = 0;

		private async void Form1_Load(object sender, EventArgs e)
		{
			#region Dollar
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "YOUR_API_KEY_HERE" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				var json = JObject.Parse(body);
				var value = json["result"].ToString();
				lblDollar.Text = "Dolar :" + value;
				dollar = decimal.Parse(value);
				//Console.WriteLine(body);

			}
			#endregion
			#region Euro
			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "YOUR_API_KEY_HERE" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response2 = await client2.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				var json2 = JObject.Parse(body2);
				var value2 = json2["result"].ToString();
				lblEuro.Text = "Euro :" + value2;
				euro = decimal.Parse(value2);
				//Console.WriteLine(body);

			}
			#endregion
			#region Pound
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=TRY&amount=1"),
				Headers =
	{
		{ "x-rapidapi-key", "YOUR_API_KEY_HERE" },
		{ "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
	},
			};
			using (var response3 = await client3.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				var json3 = JObject.Parse(body3);
				var value3 = json3["result"].ToString();
				lblSterlin.Text = "Sterlin :" + value3;
				pound = decimal.Parse(value3);
				//Console.WriteLine(body);

			}
			#endregion
			txtTotalPrice.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
			{
				MessageBox.Show("Lütfen birim fiyat giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			decimal unitPrice = unitPrice = decimal.Parse(txtUnitPrice.Text);
			decimal totalPrice = 0;
			if (rdbDollar.Checked)
			{
				totalPrice = unitPrice * dollar;
			}
			if(rdbEuro.Checked)
			{
				totalPrice = unitPrice * euro;
			}
			if (rdbSterlin.Checked)
			{
				totalPrice = unitPrice * pound;
			}
			if (!rdbDollar.Checked && !rdbEuro.Checked && !rdbSterlin.Checked)
			{
				MessageBox.Show("Lütfen bir para birimi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return; 
			}
			if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
			{
				MessageBox.Show("Lütfen birim fiyat giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			txtTotalPrice.Text = totalPrice.ToString();
		}

		private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '.')
			{
				e.KeyChar = ','; // Noktayı virgüle çevir
			}
			// Sadece rakamlar, virgül ve backspace'e izin ver
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
			{
				e.Handled = true; // Karakteri engelle
			}

			// Virgülün sadece bir kere girilmesine izin ver
			if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
			{
				e.Handled = true;
			}
		}
	}
}

