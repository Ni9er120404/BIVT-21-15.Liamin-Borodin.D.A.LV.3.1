using System.Text;

namespace LaboratoryWork.OOP._3._1
{
	public class PersonOfTheYear : IPersonOfTheYear
	{
		public string GetTopNames(string namesText)
		{
			if (string.IsNullOrWhiteSpace(namesText))
			{
				return string.Empty;
			}

			StringBuilder result = new StringBuilder();
			string[] names = namesText.Split(' ');
			Dictionary<string, int> nameOccurrences = new Dictionary<string, int>();

			foreach (string name in names)
			{
				if (nameOccurrences.TryGetValue(name, out int value))
				{
					nameOccurrences[name] = ++value;
				}
				else
				{
					nameOccurrences.Add(name, 1);
				}
			}

			int counter = 0;
			foreach (KeyValuePair<string, int> pair in nameOccurrences.OrderByDescending(x => x.Value))
			{
				if (counter >= 5)
				{
					break;
				}

				_ = result.Append($"{pair.Key}\t{pair.Value}\n");
				counter++;
			}

			return result.ToString();
		}
	}
}