using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderIssue
{
    public class InformationListItem : BaseViewModel
    {

        public ImageSource Indicator
        {
            get
            {
                if (Isvisible)
                    return ImageSource.FromFile("up.png");

                return ImageSource.FromFile("down.png");
            }
        }



        public string Header { get; set; }

        public Color HeaderTextColor
        {
            get
            {
                return Colors.Red;
            }
        }

        public string Mit { get; set; }

        public bool MitVisible { get { return !string.IsNullOrWhiteSpace(Mit); } }

        public string Text { get; set; }

        public bool FurtherInformations { get; set; }

        private bool isVisible;
        public bool Isvisible
        {
            get => isVisible;
            set
            {
                isVisible = value;
                FirePropertyChanged(nameof(Isvisible));
                FirePropertyChanged(nameof(Indicator));
            }
        }


    }

    public class MainPageViewModel : BaseViewModel
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public List<InformationListItem> InformationListItems { get; set; }


        public MainPageViewModel()
        {
            Header = "Sampel";
            Text = "Sampel 123456";
            InformationListItems = CreateInformationList();
        }



        private List<InformationListItem> CreateInformationList()
        {
            List<InformationListItem> items = new()
        {
            new InformationListItem()
            {
                Header = "Lorem odio et rebum soluta sed molestie",
                Text = "Vero no kasd et magna invidunt sanctus nulla esse ipsum nonumy nisl accumsan consectetuer accusam erat voluptua",
                Mit = "Lorem luptatum vel ut et gubergren",
                FurtherInformations = true,
            }

            //new InformationListItem()
            //{
            //    Header = "Ea sadipscing stet voluptua amet",
            //    Text = "Iusto sit clita volutpat consectetuer diam gubergren sit tempor gubergren consetetur iriure diam vero sed invidunt commodo vero at amet sadipscing erat",
            //    FurtherInformations = true,
            //},

            //new InformationListItem()
            //{
            //    Header = "Dolor ipsum sit aliquam vero sadipscing",
            //    Text = "Doming et ut kasd justo tempor iusto et sadipscing et et sea sit liber assum illum eirmod aliquyam sed te",
            //    FurtherInformations = true,
            //},

            //new InformationListItem()
            //{
            //    Header = "At in quis kasd et",
            //    Text = "Euismod sit vel et ut sea tempor rebum et ipsum invidunt et ipsum tempor justo volutpat ut dolor sadipscing",
            //    FurtherInformations = true,
            //},

            //new InformationListItem()
            //{
            //    Header = "Ut amet tempor lorem dolore dolore consequat",
            //    Text = "Sit commodo gubergren dolores gubergren et amet dolor et nonumy accusam at dolor nihil elitr justo placerat vero autem soluta diam ut accumsan accusam aliquyam",
            //    FurtherInformations = true,
            //}
        };



            return items;
        }

    }
}
