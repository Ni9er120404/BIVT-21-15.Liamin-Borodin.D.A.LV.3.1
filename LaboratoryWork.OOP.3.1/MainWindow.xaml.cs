using System.Windows;
using System.Windows.Documents;

namespace LaboratoryWork.OOP._3._1
{
	public partial class MainWindow : Window
	{
		private readonly IPersonOfTheYear _personOfTheYear;

		public MainWindow(IPersonOfTheYear personOfTheYear)
		{
			InitializeComponent();
			_personOfTheYear = personOfTheYear;
		}

		private void CalculateButtonClick(object sender, RoutedEventArgs e)
		{
			string namesText = new TextRange(inputRichTextBox.Document.ContentStart, inputRichTextBox.Document.ContentEnd).Text;
			string resultText = _personOfTheYear.GetTopNames(namesText);
			resultRichTextBox.Document = new FlowDocument(new Paragraph(new Run(resultText)));
		}
	}
}