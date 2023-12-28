using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace CurrencyConverter_Static
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Root val = new Root();
        public class Root
        {
            public Rate rates { get; set; }
            public long timestamp { get; set; }
            public string license { get; set; }
        }

        public class Rate
        {
            public double AED { get; set; }
            public double AFN { get; set; }
            public double ALL { get; set; }
            public double AMD { get; set; }
            public double ANG { get; set; }
            public double AOA { get; set; }
            public double ARS { get; set; }
            public double AUD { get; set; }
            public double AWG { get; set; }
            public double AZN { get; set; }
            public double BAM { get; set; }
            public double BBD { get; set; }
            public double BDT { get; set; }
            public double BGN { get; set; }
            public double BHD { get; set; }
            public double BIF { get; set; }
            public double BMD { get; set; }
            public double BND { get; set; }
            public double BOB { get; set; }
            public double BRL { get; set; }
            public double BSD { get; set; }
            public double BTC { get; set; }
            public double BTN { get; set; }
            public double BWP { get; set; }
            public double BYN { get; set; }
            public double BZD { get; set; }
            public double CAD { get; set; }
            public double CDF { get; set; }
            public double CHF { get; set; }
            public double CLF { get; set; }
            public double CLP { get; set; }
            public double CNH { get; set; }
            public double CNY { get; set; }
            public double COP { get; set; }
            public double CRC { get; set; }
            public double CUC { get; set; }
            public double CUP { get; set; }
            public double CVE { get; set; }
            public double CZK { get; set; }
            public double DJF { get; set; }
            public double DKK { get; set; }
            public double DOP { get; set; }
            public double DZD { get; set; }
            public double EGP { get; set; }
            public double ERN { get; set; }
            public double ETB { get; set; }
            public double EUR { get; set; }
            public double FJD { get; set; }
            public double FKP { get; set; }
            public double GBP { get; set; }
            public double GEL { get; set; }
            public double GGP { get; set; }
            public double GHS { get; set; }
            public double GIP { get; set; }
            public double GMD { get; set; }
            public double GNF { get; set; }
            public double GTQ { get; set; }
            public double GYD { get; set; }
            public double HKD { get; set; }
            public double HNL { get; set; }
            public double HRK { get; set; }
            public double HTG { get; set; }
            public double HUF { get; set; }
            public double IDR { get; set; }
            public double ILS { get; set; }
            public double IMP { get; set; }
            public double INR { get; set; }
            public double IQD { get; set; }
            public double IRR { get; set; }
            public double ISK { get; set; }
            public double JEP { get; set; }
            public double JMD { get; set; }
            public double JOD { get; set; }
            public double JPY { get; set; }
            public double KES { get; set; }
            public double KGS { get; set; }
            public double KHR { get; set; }
            public double KMF { get; set; }
            public double KPW { get; set; }
            public double KRW { get; set; }
            public double KWD { get; set; }
            public double KYD { get; set; }
            public double KZT { get; set; }
            public double LAK { get; set; }
            public double LBP { get; set; }
            public double LKR { get; set; }
            public double LRD { get; set; }
            public double LSL { get; set; }
            public double LYD { get; set; }
            public double MAD { get; set; }
            public double MDL { get; set; }
            public double MGA { get; set; }
            public double MKD { get; set; }
            public double MMK { get; set; }
            public double MNT { get; set; }
            public double MOP { get; set; }
            public double MRU { get; set; }
            public double MUR { get; set; }
            public double MVR { get; set; }
            public double MWK { get; set; }
            public double MXN { get; set; }
            public double MYR { get; set; }
            public double MZN { get; set; }
            public double NAD { get; set; }
            public double NGN { get; set; }
            public double NIO { get; set; }
            public double NOK { get; set; }
            public double NPR { get; set; }
            public double NZD { get; set; }
            public double OMR { get; set; }
            public double PAB { get; set; }
            public double PEN { get; set; }
            public double PGK { get; set; }
            public double PHP { get; set; }
            public double PKR { get; set; }
            public double PLN { get; set; }
            public double PYG { get; set; }
            public double QAR { get; set; }
            public double RON { get; set; }
            public double RSD { get; set; }
            public double RUB { get; set; }
            public double RWF { get; set; }
            public double SAR { get; set; }
            public double SBD { get; set; }
            public double SCR { get; set; }
            public double SDG { get; set; }
            public double SEK { get; set; }
            public double SGD { get; set; }
            public double SHP { get; set; }
            public double SLL { get; set; }
            public double SOS { get; set; }
            public double SRD { get; set; }
            public double SSP { get; set; }
            public double STD { get; set; }
            public double STN { get; set; }
            public double SVC { get; set; }
            public double SYP { get; set; }
            public double SZL { get; set; }
            public double THB { get; set; }
            public double TJS { get; set; }
            public double TMT { get; set; }
            public double TND { get; set; }
            public double TOP { get; set; }
            public double TRY { get; set; }
            public double TTD { get; set; }
            public double TWD { get; set; }
            public double TZS { get; set; }
            public double UAH { get; set; }
            public double UGX { get; set; }
            public double USD { get; set; }
            public double UYU { get; set; }
            public double UZS { get; set; }
            public double VES { get; set; }
            public double VND { get; set; }
            public double VUV { get; set; }
            public double WST { get; set; }
            public double XAF { get; set; }
            public double XAG { get; set; }
            public double XAU { get; set; }
            public double XCD { get; set; }
            public double XDR { get; set; }
            public double XOF { get; set; }
            public double XPD { get; set; }
            public double XPF { get; set; }
            public double XPT { get; set; }
            public double YER { get; set; }
            public double ZAR { get; set; }
            public double ZMW { get; set; }
            public double ZWL { get; set; }
        }

        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        private int CurrencyId = 0;
        private double FromAmount = 0;
        private double ToAmount = 0;
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
            GetData();  
        }

        public static async Task<Root> GetData<T>(string url)
        {
            var myRoot = new Root();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromMinutes(1);
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var ResponseString = await response.Content.ReadAsStringAsync();
                        var ResponseObject = JsonConvert.DeserializeObject<Root>(ResponseString);

                        MessageBox.Show("TimeStamp: " + ResponseObject.timestamp, "Information", MessageBoxButton.OK);

                        return ResponseObject;
                    }
                    return myRoot;  
                }
            } catch 
            {
                return myRoot;
            }
        }

        private async void GetValue()
        {
            val = await GetData<Root>("https://openexchangerates.org/api/latest.json?app_id=7ad79c9a25654685b17df1394fc655e2");
            BindCurrency();
        }

        public void mycon()
        {
            string Conn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(Conn);
            sqlConnection.Open();
        }

        private void BindCurrency()
        {
            mycon();
            DataTable dt = new DataTable();

            sqlCommand = new SqlCommand("SELECT Id, CurrencyName FROM Currency_Master", sqlConnection);
            sqlCommand.CommandType = CommandType.Text;
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dt);

            DataRow newRow = dt.NewRow();

            newRow["Id"] = 0;
            newRow["CurrencyName"] = "--SELECT--";

            dt.Rows.InsertAt(newRow, 0);

            if (dt != null & dt.Rows.Count > 0)
            {
                cmbFromCurrency.ItemsSource = dt.DefaultView;
                cmbToCurrency.ItemsSource = dt.DefaultView;  
            }
            sqlConnection.Close();

            cmbFromCurrency.ItemsSource = dt.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "CurrencyName";
            cmbFromCurrency.SelectedValuePath = "Id";   

            cmbToCurrency.ItemsSource = dt.DefaultView;
            cmbToCurrency.DisplayMemberPath = "CurrencyName";
            cmbToCurrency.SelectedValuePath = "Id";
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            //Create a variable as ConvertedValue with double data type to store currency converted value
            double ConvertedValue;

            //Check amount textbox is Null or Blank
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                //If amount textbox is Null or Blank it will show the below message box   
                MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //After clicking on message box OK sets the Focus on amount textbox
                txtCurrency.Focus();
                return;
            }
            //Else if the currency from is not selected or it is default text --SELECT--
            else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0)
            {
                //It will show the message
                MessageBox.Show("Please Select Currency From", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //Set focus on From Combobox
                cmbFromCurrency.Focus();
                return;
            }
            //Else if Currency To is not Selected or Select Default Text --SELECT--
            //If From and To Combobox selected values are same
            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                //The amount textbox value set in ConvertedValue.
                //double.parse is used to convert datatype String To Double.
                //Textbox text have string and ConvertedValue is double datatype
                ConvertedValue = double.Parse(txtCurrency.Text);

                //Show in label converted currency and converted currency name.
                // and ToString("N3") is used to place 000 after after the(.)
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
            else
            {

                //Calculation for currency converter is From Currency value multiply(*) 
                // with amount textbox value and then the total is divided(/) with To Currency value
                ConvertedValue = (double.Parse(cmbFromCurrency.SelectedValue.ToString()) * double.Parse(txtCurrency.Text)) / double.Parse(cmbToCurrency.SelectedValue.ToString());

                //Show in label converted currency and converted currency name.
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ClearControls();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            //Regex regex = new Regex("[^0-9]+");
            Regex regex = new Regex("[^0-9]+([^\\.]{1}[^0-9]{2})?");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ClearControls()
        {
            txtCurrency.Text = string.Empty;
            if (cmbFromCurrency.Items.Count > 0)
                cmbFromCurrency.SelectedIndex = 0;
            if (cmbToCurrency.Items.Count > 0)
                cmbToCurrency.SelectedIndex = 0;
            lblCurrency.Content = "";
            txtCurrency.Focus(); 
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClearMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {  
            try
            {
                if (txtAmount.Text == null || txtAmount.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter amount", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtAmount.Focus();
                    return;
                }   
                else if (txtCurrencyName.Text == null || txtCurrencyName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter currency name", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtCurrencyName.Focus();
                    return;
                }
                else
                {
                    if (CurrencyId > 0) // if currencyId is greater than zero, then go for update
                    {
                        if (MessageBox.Show("Are you sure you want to update ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            mycon();
                            DataTable dt = new DataTable();

                            sqlCommand = new SqlCommand("UPDATE Currency_Master SET Amount = @Amount, CurrencyName = @CurrencyName WHERE Id = @Id", sqlConnection);
                            sqlCommand.CommandType = CommandType.Text;

                            sqlCommand.Parameters.AddWithValue("@Id", CurrencyId);
                            sqlCommand.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            sqlCommand.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close(); 

                            MessageBox.Show("Data updated successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information ); 
                        }
                    } else  // Insert a new record
                    {
                        if (MessageBox.Show("Are you sure you want to save this new record ? ", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            mycon();

                            sqlCommand = new SqlCommand("INSERT INTO Currency_Master (Amount, CurrencyName) VALUES (@Amount, @CurrencyName)", sqlConnection);
                            sqlCommand.CommandType = CommandType.Text;

                            sqlCommand.Parameters.AddWithValue("@Amount", txtAmount.Text);
                            sqlCommand.Parameters.AddWithValue("@CurrencyName", txtCurrencyName.Text);

                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("New currency inserted sucessfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        
                    }
                    ClearMaster();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearMaster()
        {
            try
            {
                txtAmount.Text = string.Empty; 
                txtCurrencyName.Text = string.Empty;
                btnSave.Content = "Save";
                GetData();
                CurrencyId = 0;
                BindCurrency();
                txtAmount.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GetData()
        {
            mycon();
            DataTable dt = new DataTable();
            sqlCommand = new SqlCommand("SELECT * FROM Currency_Master", sqlConnection);

            sqlCommand.CommandType = CommandType.Text;  
            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                dgvCurrency.ItemsSource = dt.DefaultView;
            } else
            {
                dgvCurrency.ItemsSource = null;
            }
            sqlConnection.Close();

        }

        private void dgvCurrency_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                DataGrid dataGrid = new DataGrid();
                DataRowView row_selected = dataGrid.CurrentItem as DataRowView;

                if (row_selected != null)
                {
                    if (dgvCurrency.Items.Count > 0)
                    {
                        if (dataGrid.SelectedCells.Count > 0)
                        {
                            CurrencyId = Int32.Parse(row_selected["Id"].ToString()); // Retrieve the selected Id from the column

                            if (dataGrid.SelectedCells[0].Column.DisplayIndex == 0)  // Click on the Edit cell
                            {
                                txtAmount.Text = row_selected["Amount"].ToString();
                                txtCurrencyName.Text = row_selected["CurrencyName"].ToString();

                                btnSave.Content = "Update";
                            }

                            if (dataGrid.SelectedCells[0].Column.DisplayIndex == 1)
                            {
                                try
                                {
                                    if (MessageBox.Show("Are you sure you want to delete this currency ? ", "Information", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                                    {
                                        mycon();
                                        DataTable dataTable = new DataTable(); 
                                        sqlCommand = new SqlCommand("DELETE FROM Currency_Master WHERE Id = @Id", sqlConnection);
                                        sqlCommand.CommandType = CommandType.Text;

                                        sqlCommand.Parameters.AddWithValue("@Id", CurrencyId);
                                        sqlCommand.ExecuteNonQuery();

                                        sqlConnection.Close();
                                        MessageBox.Show("Currency deleted successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                                        ClearMaster();
                                    }
                                } catch (Exception ex) 
                                {
                                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region Selection Changed Events
        private void dgvCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //If cmbFromCurrency selected value is not equal to null and not equal to zero

                if (cmbFromCurrency.SelectedValue != null 
                    && int.Parse(cmbFromCurrency.SelectedValue.ToString()) != 0 
                    && cmbFromCurrency.SelectedIndex != 0) 
                {
                    //cmbFromCurrency selectedvalue set in CurrencyFromId variable
                    int CurrencyFromId = int.Parse(cmbFromCurrency.SelectedValue.ToString());

                    mycon();
                    DataTable dataTable = new DataTable();

                    //Select query to get amount from database using id
                    sqlCommand = new SqlCommand("SELECT Amount FROM Currency_Master WHERE Id = @Id", sqlConnection);
                    sqlCommand.CommandType = CommandType.Text;

                    //CurrencyFromId set in @CurrencyFromId parameter and send parameter in our query
                    sqlCommand.Parameters.AddWithValue("@Id", CurrencyFromId);
                    //Set the data that the query returns in the data table
                    sqlCommand.ExecuteNonQuery();

                    sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }





            //Get amount column value from datatable and set amount value in From amount variable which is declared globally

        }
        #endregion
    }
}
