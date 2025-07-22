using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace CircodeApps
{
    public partial class frmClima : Form
    {
        private const string ApiKey = "a76e98b418728200c0cfb6520e085262";
        private const string ApiBaseURL = "http://api.openweathermap.org/data/2.5/weather";
        public frmClima()
        {
            InitializeComponent();
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            string city = txtCidade.Text.Trim();
            if (!string.IsNullOrEmpty(city))
            {
                string apiUrl = $"{ApiBaseURL}?lang=pt_br&q={city}&appid={ApiKey}&units=metric";
                try
                {
                    string jsonResponse = await FetchDataAsync(apiUrl);
                    DisplayWeather(jsonResponse);
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro: {er.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome da cidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<string> FetchDataAsync(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    throw new HttpRequestException($"Falha. Não consegui recuperar os dados! Código{response.StatusCode}.");
                }
            }
        }

        private void DisplayWeather(string jsonResponse)
        {
            JObject data = JObject.Parse(jsonResponse);
            string nomecidade = data["name"].ToString();
            string temperatura = data["main"]["temp"].ToString();
            string descricao = data["weather"][0]["description"].ToString();
            string umidade = data["main"]["humidity"].ToString();
            string pressao = data["main"]["pressure"].ToString();
            string pais = data["sys"]["country"].ToString();
            lblCidade.Text = $"Cidade: {nomecidade}";
            lblTemperatura.Text = $"Temperatura: {temperatura} ºC";
            lblDescricao.Text = $"Descrição: {descricao}";
            lblUmidade.Text = $"Umidade: {umidade}%";
            lblPressao.Text = $"Pressão Atmosférica: {pressao} hPa";
            lblPais.Text = $"País: {pais}";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
