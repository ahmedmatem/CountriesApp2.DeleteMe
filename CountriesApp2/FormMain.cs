using CountriesApp2.Data;
using CountriesApp2.Data.Models;

namespace CountriesApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ReloadCountries();
            ReloadTowns();
        }

        private List<Country> LoadCountriesFromDb()
        {
            using (var context = new CountriesDbContext())
            {
                return context.Countries.ToList();
            }
        }

        private List<Town> LoadTownsFromDb(int countryId = 0)
        {
            using (var context = new CountriesDbContext())
            {
                if (countryId == 0) // всички градове
                {
                    return context.Towns.ToList();
                }

                return context.Towns
                    // включваме градовете, които принадлежат на държава с 'countryId'
                    .Where(t => t.CountryId == countryId)
                    .ToList();
            }
        }

        private void ReloadCountries()
        {
            var countries = LoadCountriesFromDb();
            countryBindingSource.DataSource = countries;
        }

        // countryId = 0 означава всички градове,
        // иначе само тези от съответната държава
        private void ReloadTowns(int countryId = 0)
        {
            var towns = LoadTownsFromDb(countryId);
            townBindingSource.DataSource = towns;
        }

        private void OnCountrySelectionChanged(object sender, EventArgs e)
        {
            var country = (Country)countryBindingSource.Current;
            if (country is null) return;
            ReloadTowns(country.CountryId);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            var filterText = textBoxFilter.Text;
            if (string.IsNullOrEmpty(filterText))
            {
                ReloadCountries();
                ReloadTowns();
                return;
            }

            using (var context = new CountriesDbContext())
            {
                var filteredCountries = context.Countries
                    .Where(c => c.CountryName.ToLower()
                        .Contains(filterText.ToLower()))
                    .ToList();
                countryBindingSource.DataSource = filteredCountries;
            }
        }

        private void OnSelectionIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = comboBoxSort.SelectedIndex;
        }
    }
}
