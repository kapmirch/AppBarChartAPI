using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;



namespace AppBarChartAPI
{
    public partial class AppBarChartAPI : Form
    {
        string[] myArr;
        WebClient wc = new WebClient();

        public AppBarChartAPI()
        {
            InitializeComponent();
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // radiobutton1 = IBM

                if ((radioButton1.Checked) && (comboBox1.Text == "minutes"))
                {
                     
                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "nearByMinutes"))
                    {

                        label1.Text = fbd.SelectedPath;

                        Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=nearByMinutes&startDate=20150106000000");
                        wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                        FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        DataSet ds = new DataSet();
                        ds.Tables.Add("FinanceData");
                        ds.Tables["FinanceData"].Columns.Add("Symbol");
                        ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                        ds.Tables["FinanceData"].Columns.Add("TradingDay");
                        ds.Tables["FinanceData"].Columns.Add("Open");
                        ds.Tables["FinanceData"].Columns.Add("High");
                        ds.Tables["FinanceData"].Columns.Add("Low");
                        ds.Tables["FinanceData"].Columns.Add("Close");
                        ds.Tables["FinanceData"].Columns.Add("Volume");
                        ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                        string item;
                        while ((item = sr.ReadLine()) != null)
                        {
                            myArr = item.Split(',');
                            ds.Tables["FinanceData"].Rows.Add(myArr);
                        }

                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                        dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                        dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                    }
                else if ((radioButton1.Checked) && (comboBox1.Text == "formTMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=formTMinutes&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "daily"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=daily&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "dailyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=dailyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "dailyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=dailyContinue&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "weekly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=weekly&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "weeklyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=weeklyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "weeklyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=weeklyContinue&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                 else if ((radioButton1.Checked) && (comboBox1.Text == "monthly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=monthly&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "monthlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=monthlyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "monthlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=monthlyContinue&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "quarterly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=quarterly&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "quarterlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=quarterlyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "quarterlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=quarterlyContinue&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "yearly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=yearlyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "yearlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=yearlyNearest&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton1.Checked) && (comboBox1.Text == "yearlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri IBMurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=IBM&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(IBMurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }

                // radiobutton2 = GOOGL

                else if ((radioButton2.Checked) && (comboBox1.Text == "minutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "nearbyMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=nearbyMinutes&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "formTMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=formTMinutes&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "daily"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=daily&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "dailyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=dailyNearest&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "dailyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=dailyContinue&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "weekly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=weekly&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "weeklyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=weeklyNearest&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "weeklyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=weeklyContinue&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "monthly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=monthly&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "monthlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=monthlyNearest&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "monthlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=monthlyContinue&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "quarterly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=quarterly&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "quarterlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=quarterlyNearest&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "quarterlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=quarterlyContinue&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "yearly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=yearly&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "yearlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=yearlyNearest&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton2.Checked) && (comboBox1.Text == "yearlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri GOOGLurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=GOOGL&type=yearlyContinue&startDate=20150106000000");
                    wc.DownloadFile(GOOGLurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }

                // radioButton3 = ZCH

                else if ((radioButton3.Checked) && (comboBox1.Text=="minutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "nearbyMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=nearbyMinutes&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "formTMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=formTMinutes&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "daily"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=daily&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "dailyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=dailyNearest&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "dailyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=dailyContinue&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "weekly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=weekly&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "weeklyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=weeklyNearest&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "weeklyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=weeklyContinue&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "monthly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=monthly&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "monthlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=monthlyNearest&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "monthlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=monthlyContinue&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "quarterly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=quarterly&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "quarterlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=quarterlyNearest&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "quarterlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=quarterlyContinue&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "yearly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=yearly&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "yearlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=yearlyNearest&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton3.Checked) && (comboBox1.Text == "yearlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri ZCH16url = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=ZCH16&type=yearlyContinue&startDate=20150106000000");
                    wc.DownloadFile(ZCH16url, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }

                // radio4 =^EURUSD

                else if ((radioButton4.Checked) && (comboBox1.Text=="minutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=minutes&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "nearbyMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=nearbyMinutes&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "formTMinutes"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=formTMinutes&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "daily"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=daily&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "dailyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=dailyNearest&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "dailyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=dailyContinue&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "weekly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=weekly&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "weeklyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=weeklyNearest&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "weeklyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=weeklyContinue&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "monthly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=monthly&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "monthlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=monthlyNearest&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "monthlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=monthlyContinue&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "quarterly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=quarterly&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "quarterlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=quarterlyNearest&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "quarterlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=quarterlyContinue&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "yearly"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=yearly&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "yearlyNearest"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=yearlyNearest&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else if ((radioButton4.Checked) && (comboBox1.Text == "yearlyContinue"))
                {

                    label1.Text = fbd.SelectedPath;

                    Uri EURUSDurl = new Uri(@"http://marketdata.websol.barchart.com/getHistory.csv?key=6d52a44197be77bec9c88f260366e643&symbol=^EURUSD&type=yearlyContinue&startDate=20150106000000");
                    wc.DownloadFile(EURUSDurl, label1.Text + @"\GetHistory.csv");

                    FileStream fs = new FileStream(label1.Text + @"\GetHistory.csv", FileMode.Open);
                    StreamReader sr = new StreamReader(fs);
                    DataSet ds = new DataSet();
                    ds.Tables.Add("FinanceData");
                    ds.Tables["FinanceData"].Columns.Add("Symbol");
                    ds.Tables["FinanceData"].Columns.Add("TimeStamp");
                    ds.Tables["FinanceData"].Columns.Add("TradingDay");
                    ds.Tables["FinanceData"].Columns.Add("Open");
                    ds.Tables["FinanceData"].Columns.Add("High");
                    ds.Tables["FinanceData"].Columns.Add("Low");
                    ds.Tables["FinanceData"].Columns.Add("Close");
                    ds.Tables["FinanceData"].Columns.Add("Volume");
                    ds.Tables["FinanceData"].Columns.Add("OpenInterest");

                    string item;
                    while ((item = sr.ReadLine()) != null)
                    {
                        myArr = item.Split(',');
                        ds.Tables["FinanceData"].Rows.Add(myArr);
                    }

                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                    dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);


                }
                else
                {
                    MessageBox.Show("Please Make Your Selections");
                }



            }
        }

       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                label1.Text = fbd.SelectedPath;
                Uri QuoteUrl = new Uri(@"http://marketdata.websol.barchart.com/getQuote.csv?key=6d52a44197be77bec9c88f260366e643&symbols=ZC*1,IBM,GOOGL,^EURUSD");
                wc.DownloadFile(QuoteUrl, label1.Text + @"\GetQuote.csv");

                FileStream fs = new FileStream(label1.Text + @"\GetQuote.csv", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                DataSet ds = new DataSet();
                ds.Tables.Add("QuoteData");
                ds.Tables["QuoteData"].Columns.Add("Symbol");
                ds.Tables["QuoteData"].Columns.Add("Exchange");
                ds.Tables["QuoteData"].Columns.Add("Name");
                ds.Tables["QuoteData"].Columns.Add("dayCode");
                ds.Tables["QuoteData"].Columns.Add("serverTimeStamp");
                ds.Tables["QuoteData"].Columns.Add("Mode");
                ds.Tables["QuoteData"].Columns.Add("LastPrice");
                ds.Tables["QuoteData"].Columns.Add("tradeTimeStamp");
                ds.Tables["QuoteData"].Columns.Add("netChange");
                ds.Tables["QuoteData"].Columns.Add("Percent");
                ds.Tables["QuoteData"].Columns.Add("Change");
                ds.Tables["QuoteData"].Columns.Add("unitCode");
                ds.Tables["QuoteData"].Columns.Add("Open");
                ds.Tables["QuoteData"].Columns.Add("High");
                ds.Tables["QuoteData"].Columns.Add("Low");
                ds.Tables["QuoteData"].Columns.Add("Close");
                ds.Tables["QuoteData"].Columns.Add("Flag");
                ds.Tables["QuoteData"].Columns.Add("Volume");


                string item;
                while ((item = sr.ReadLine()) != null)
                {
                    myArr = item.Split(',');
                    ds.Tables["QuoteData"].Rows.Add(myArr);
                }

                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string constring = @"Data Source=KapilPrity;Initial Catalog=webAPI;Integrated Security=true";
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO getHistoryTable VALUES(@Symbol, @TimeStamp, @TradingDay, @open, @high, @low, @close, @volume, @openInterest)", con))
                    {
                       

                        cmd.Parameters.AddWithValue("@Symbol", row.Cells["symbol"].Value);
                        cmd.Parameters.AddWithValue("@TimeStamp", row.Cells["timestamp"].Value);
                        cmd.Parameters.AddWithValue("@TradingDay", row.Cells["tradingDay"].Value);
                        cmd.Parameters.AddWithValue("@open", row.Cells["open"].Value );
                        cmd.Parameters.AddWithValue("@high", row.Cells["high"].Value);
                        cmd.Parameters.AddWithValue("@low", row.Cells["low"].Value);
                        cmd.Parameters.AddWithValue("@close", row.Cells["close"].Value);
                        cmd.Parameters.AddWithValue("@volume", row.Cells["volume"].Value);
                        cmd.Parameters.AddWithValue("@openInterest", row.Cells["openInterest"].Value);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            MessageBox.Show("Records inserted in SQL Table.");
        }
       }
   }

