using SunmiPOSLib;
using SunmiPOSLib.Enum;
using SunmiPOSLib.Models;
using SunmiPOSLib.Services;
using ZXing.Net.Maui.Controls;

namespace SunmiSampleApp.Views;

public partial class QrcodePage : ContentPage
{
    private readonly string[] QrcodeSizeList = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
    private readonly string[] QrcodeLevelList = { "L correction (7%)", "Fix M (15%)", "Q correction (25%)", "Correction H (30%)" };
    private readonly string[] QrcodeAlignList = { "Left", "Center", "Right" };

    public QrcodePage()
    {
        InitializeComponent();
        InitializeValues();
    }
    private void InitializeValues()
    {
        var QrcodeLabelZxing = this.FindByName<BarcodeGeneratorView>("BarcodeImageView");
        var QrcodeLabel = this.FindByName<Label>("QrcodeLabel");
        var SizeLabel = this.FindByName<Label>("SizeLabel");
        var LevelLabel = this.FindByName<Label>("LevelLabel");
        var AlignLabel = this.FindByName<Label>("AlignLabel");

        QrcodeLabelZxing.Value = "www.tectoySunmi.com.br";
        QrcodeLabel.Text = "www.tectoySunmi.com.br";
        SizeLabel.Text = QrcodeSizeList[0];
        LevelLabel.Text = QrcodeLevelList[0];
        AlignLabel.Text = QrcodeAlignList[0];
    }

    /// <summary>
    /// Changes the QRcode content taking the input from the QRcode screen
    /// </summary>
    private async void OnQrcodeChange(object sender, EventArgs e)
    {
        var qrcodeLabel = this.FindByName<Label>("QrcodeLabel");
        var qrcodeLabelZxing = this.FindByName<BarcodeGeneratorView>("BarcodeImageView");
        var qrcodeContent = await DisplayPromptAsync(null, "Enter QRcode content", placeholder: "www.tectoySunmi.com.br");
        if (qrcodeContent != null && qrcodeContent != "")
        {
            qrcodeLabelZxing.Value = qrcodeContent;
            qrcodeLabel.Text = qrcodeContent;
        }
    }

    /// <summary>
    /// Changes the QRcode size taking the input from the QRcode screen
    /// </summary>
    private async void OnSizeChange(object sender, EventArgs e)
    {
        var sizeLabel = this.FindByName<Label>("SizeLabel");
        var qrcodeSize = await DisplayActionSheet("QR-Code size", "Cancel", null, QrcodeSizeList);
        if ((qrcodeSize != "Cancel") && (qrcodeSize != null))
        {
            sizeLabel.Text = qrcodeSize;
        }
    }
    /// <summary>
    /// Changes the QRcode correction level taking the input from the QRcode screen
    /// </summary>
    private async void OnLevelChange(object sender, EventArgs e)
    {
        var levelLabel = this.FindByName<Label>("LevelLabel");
        var qrcodeLevel = await DisplayActionSheet("Correction level", "Cancel", null, QrcodeLevelList);
        if ((qrcodeLevel != "Cancel") && (qrcodeLevel != null))
        {
            levelLabel.Text = qrcodeLevel;
        }
    }
    /// <summary>
    /// Changes the QRcode alignment taking the input from the QRcode screen
    /// </summary>
    private async void OnAlignChange(object sender, EventArgs e)
    {
        var alignLabel = this.FindByName<Label>("AlignLabel");
        var qrcodeAlign = await DisplayActionSheet("Alignment", "Cancel", null, QrcodeAlignList);
        if ((qrcodeAlign != "Cancel") && (qrcodeAlign != null))
        {
            alignLabel.Text = qrcodeAlign;
        }
    }

    /// <summary>
    /// Instantiates a QRcode with the data setted
    /// </summary>
    private QRcode GetQrcodeEntity()
    {
        // Content 
        var qrcodeLabel = this.FindByName<Label>("QrcodeLabel");

        // Size
        var sizeLabel = this.FindByName<Label>("SizeLabel");
        var size = Int32.Parse(sizeLabel.Text);

        // Correction
        var levelLabel = this.FindByName<Label>("LevelLabel");
        QRCodeCorretionEnum level;
        if (levelLabel.Text == "Correção L (7%)")
        {
            level = QRCodeCorretionEnum.CORRECTION_L;
        }
        else if (levelLabel.Text == "Correção M (15%)")
        {
            level = QRCodeCorretionEnum.CORRECTION_M;
        }
        else if (levelLabel.Text == "Correção Q (25%)")
        {
            level = QRCodeCorretionEnum.CORRECTION_Q;
        }
        else
        {
            level = QRCodeCorretionEnum.CORRECTION_H;
        }

        // Alignment 
        var alignLabel = this.FindByName<Label>("AlignLabel");
        AlignmentEnum align;
        if (alignLabel.Text == "Left")
        {
            align = AlignmentEnum.LEFT;
        }
        else if (alignLabel.Text == "Center")
        {
            align = AlignmentEnum.CENTER;
        }
        else
        {
            align = AlignmentEnum.RIGHT;
        }

        // Cut
        var cutLabel = this.FindByName<Switch>("CutLabel");

        return new QRcode(
            content: qrcodeLabel.Text,
            impsize: size,
            correction: level,
            alignment: align,
            cutPaper: cutLabel.IsToggled);
    }
    /// <summary>
    /// Send the QRcode entity to the QRcodeService class
    /// </summary>
    private async void OnPrint(object sender, EventArgs e)
    {
        try
        {
            var wasSuccessful = SunmiPrinter.Current.PrintQRCode(GetQrcodeEntity());
        }
        catch (Exception exception)
        {
            await DisplayAlert("Error", exception.Message, "ok");
        }
    }
}
