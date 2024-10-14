namespace project1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void lblProducts_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        //butonun d�zg�n �al��mas� i�in bir�ok yere �zellik eklenir.

        //uygulama a��ld��� zaman i�indeki kod �al���r.

        var productsText = "�r�nler";
        var addToCartButtonText = "Sepete Ekle";
        var cartText = "Sepetiniz";
        var removeFromTheCartButtonText = "Sepetten ��kar";

        lblProducts.Text = productsText;
        lblCart.Text = cartText;
        btnAddToCart.Text = addToCartButtonText;
        btnRemoveFromTheCart.Text = removeFromTheCartButtonText;
        //lblProducts.Text = "�r�nler"; 
        //B�yle yazmay�p de�i�kenli yazmamam�z�n sebebi sonradan olabilecek de�i�iklilkerdir.

        string[] products = new string[] { "Araba kirala", "Araba sat�n al ", "Araba iade et" };

        //for (int i = 0; i < products.Length; i++)
        //{
        //    lbxProducts.Items.Add(products[i]);
        //}

        // for d�ng�s� yerine foreach d�ng�s� de kullan�labilir.

        foreach (var item in products)
        {
            lbxProducts.Items.Add(item);
        }

        //lbxProducts.Items.Add("Laptop");
        //lbxProducts.Items.Add("Masa�st� PC");
        //lbxProducts.Items.Add("Klavye");
        //Array i�inden bilgi �ekmek ve kod k�saltmak i�in i�in b�yle yapt�k.

        //e�er sepetimiz bo�sa ��karma butonu aktif olmas�n
        if (lbxCart.Items.Count == 0)
            btnRemoveFromTheCart.Enabled = false;
        if (lbxProducts.SelectedItem == null)
        {
            btnAddToCart.Enabled = false;
        }

    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        //se�ili �r�n� tek tek mesaj olarak g�sterir
        //MessageBox.Show(lbxProducts.SelectedItem.ToString());
        //�r�nler k�sm�ndaki se�ili �r�n� sepete ekler

        if (lbxProducts.SelectedItem != null)
        {
            lbxCart.Items.Add(lbxProducts.SelectedItem);
            btnRemoveFromTheCart.Enabled = true;
        }
        else
            MessageBox.Show("Eklenecek �r�n� se�in ");
    }

    private void btnRemoveFromTheCart_Click(object sender, EventArgs e)
    {
        //sepeten �r�n ��karmak i�in
        if (lbxCart.SelectedItem != null)
            lbxCart.Items.Remove(lbxCart.SelectedItem);
        else
            MessageBox.Show("Silinecek �r�n� se�in");

        if (lbxCart.Items.Count == 0)
            btnRemoveFromTheCart.Enabled = false;



    }

    private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbxProducts.SelectedItem !=null)
            btnAddToCart.Enabled=true;
    }
}
