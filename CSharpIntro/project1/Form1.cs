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
        //butonun düzgün çalýþmasý için birçok yere özellik eklenir.

        //uygulama açýldýðý zaman içindeki kod çalýþýr.

        var productsText = "Ürünler";
        var addToCartButtonText = "Sepete Ekle";
        var cartText = "Sepetiniz";
        var removeFromTheCartButtonText = "Sepetten Çýkar";

        lblProducts.Text = productsText;
        lblCart.Text = cartText;
        btnAddToCart.Text = addToCartButtonText;
        btnRemoveFromTheCart.Text = removeFromTheCartButtonText;
        //lblProducts.Text = "Ürünler"; 
        //Böyle yazmayýp deðiþkenli yazmamamýzýn sebebi sonradan olabilecek deðiþiklilkerdir.

        string[] products = new string[] { "Araba kirala", "Araba satýn al ", "Araba iade et" };

        //for (int i = 0; i < products.Length; i++)
        //{
        //    lbxProducts.Items.Add(products[i]);
        //}

        // for döngüsü yerine foreach döngüsü de kullanýlabilir.

        foreach (var item in products)
        {
            lbxProducts.Items.Add(item);
        }

        //lbxProducts.Items.Add("Laptop");
        //lbxProducts.Items.Add("Masaüstü PC");
        //lbxProducts.Items.Add("Klavye");
        //Array içinden bilgi çekmek ve kod kýsaltmak için için böyle yaptýk.

        //eðer sepetimiz boþsa çýkarma butonu aktif olmasýn
        if (lbxCart.Items.Count == 0)
            btnRemoveFromTheCart.Enabled = false;
        if (lbxProducts.SelectedItem == null)
        {
            btnAddToCart.Enabled = false;
        }

    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        //seçili ürünü tek tek mesaj olarak gösterir
        //MessageBox.Show(lbxProducts.SelectedItem.ToString());
        //ürünler kýsmýndaki seçili ürünü sepete ekler

        if (lbxProducts.SelectedItem != null)
        {
            lbxCart.Items.Add(lbxProducts.SelectedItem);
            btnRemoveFromTheCart.Enabled = true;
        }
        else
            MessageBox.Show("Eklenecek ürünü seçin ");
    }

    private void btnRemoveFromTheCart_Click(object sender, EventArgs e)
    {
        //sepeten ürün çýkarmak için
        if (lbxCart.SelectedItem != null)
            lbxCart.Items.Remove(lbxCart.SelectedItem);
        else
            MessageBox.Show("Silinecek ürünü seçin");

        if (lbxCart.Items.Count == 0)
            btnRemoveFromTheCart.Enabled = false;



    }

    private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lbxProducts.SelectedItem !=null)
            btnAddToCart.Enabled=true;
    }
}
