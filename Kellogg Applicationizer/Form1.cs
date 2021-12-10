using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
//using JavascriptExecutor;

namespace Kellogg_Applicationizer
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private int rndNum(int min, int max)
        {
            int number = random.Next(min, max);
            return number;
        }

        


        string email = "";
        string pass = "UnionizeNow2021!";
        List<string> usedNames = new List<string>();

        class zip
        {
            public string Location { get; set; }
            public string code { get; set; }
            public string link { get; set; }   
            public string state { get; set; }   
        }

        List<zip> zips = new List<zip>()
        {
            new zip() { Location = "Omaha", state = "Nebraska", code = "68104", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},
            new zip() { Location = "Omaha", state = "Nebraska", code = "68105", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},
            new zip() { Location = "Omaha", state = "Nebraska", code = "68106", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},
            new zip() { Location = "Omaha", state = "Nebraska", code = "68124", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},
            new zip() { Location = "Omaha", state = "Nebraska", code = "68127", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},
            new zip() { Location = "Omaha", state = "Nebraska", code = "68134", link = "https://jobs.kellogg.com/job/Omaha-Permanent-Production-Associate-Omaha-NE-68103/817685900/z"},

            new zip() { Location = "Battle Creek", state = "Michigan", code = "49014", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},
            new zip() { Location = "Battle Creek", state = "Michigan", code = "49015", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},
            new zip() { Location = "Battle Creek", state = "Michigan", code = "49016", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},
            new zip() { Location = "Battle Creek", state = "Michigan", code = "49017", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},
            new zip() { Location = "Battle Creek", state = "Michigan", code = "49018", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},
            new zip() { Location = "Battle Creek", state = "Michigan", code = "49037", link = "https://jobs.kellogg.com/job/Battle-Creek-Permanent-Production-Associate-Battle-Creek-MI-49014/817685300/"},

            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17573", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},
            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17601", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},
            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17602", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},
            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17605", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},
            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17606", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},
            new zip() { Location = "Lancaster", state = "Pennsylvania", code = "17699", link = "https://jobs.kellogg.com/job/Lancaster-Permanent-Production-Associate-Lancaster-PA-17601/817684800/"},

            new zip() { Location = "Memphis", state = "Tennessee", code = "38116", link = "https://jobs.kellogg.com/job/Memphis-Permanent-Production-Associate-Memphis-TN-38114/817685700/"},
            new zip() { Location = "Memphis", state = "Tennessee", code = "38118", link = "https://jobs.kellogg.com/job/Memphis-Permanent-Production-Associate-Memphis-TN-38114/817685700/"},
            new zip() { Location = "Memphis", state = "Tennessee", code = "38122", link = "https://jobs.kellogg.com/job/Memphis-Permanent-Production-Associate-Memphis-TN-38114/817685700/"},
            new zip() { Location = "Memphis", state = "Tennessee", code = "38127", link = "https://jobs.kellogg.com/job/Memphis-Permanent-Production-Associate-Memphis-TN-38114/817685700/"},
            new zip() { Location = "Memphis", state = "Tennessee", code = "38134", link = "https://jobs.kellogg.com/job/Memphis-Permanent-Production-Associate-Memphis-TN-38114/817685700/"}
        };


        double counter = 0;

        public void createAcct()
        {
            
        }

        public void waitForElement(string elementName, string textToVerify)
        {
            try
            {
                if (driver.FindElement(By.XPath(elementName)).GetAttribute("innerText").Contains(textToVerify))
                {
                    return;
                }
            }
            catch
            {
                waitForElement(elementName, textToVerify);
            }
        }

        IWebDriver driver;

        private void btnStart_Click(object sender, EventArgs e)
        {
            

            driver = new ChromeDriver();

            backgroundWorker1.RunWorkerAsync();
            //createAcct();
        }
        

        string[] fnameArr = new string[]
        {
            "John",
            "Michael",
            "William",
            "David",
            "Richard",
            "Joseph",
            "Thomas",
            "Charles",
            "Christopher",
            "Daniel",
            "Matthew",
            "Anthony",
            "Mark",
            "Donald",
            "Steven",
            "Paul",
            "Andrew",
            "Joshua",
            "Kenneth",
            "Kevin",
            "Brian",
            "George",
            "Edward",
            "Ronald",
            "Timothy",
            "Jason",
            "Jeffrey",
            "Ryan",
            "Jacob",
            "Gary",
            "Nicholas",
            "Eric",
            "Jonathan",
            "Stephen",
            "Larry",
            "Justin",
            "Scott",
            "Brandon",
            "Benjamin",
            "Samuel",
            "Gregory",
            "Frank",
            "Alexander",
            "Raymond",
            "Patrick",
            "Jack",
            "Dennis",
            "Jerry",
            "Tyler",
            "Aaron",
            "Jose",
            "Adam",
            "Henry",
            "Nathan",
            "Douglas",
            "Zachary",
            "Peter",
            "Kyle",
            "Walter",
            "Ethan",
            "Jeremy",
            "Harold",
            "Keith",
            "Christian",
            "Roger",
            "Noah",
            "Gerald",
            "Carl",
            "Terry",
            "Sean",
            "Austin",
            "Arthur",
            "Lawrence",
            "Jesse",
            "Dylan",
            "Bryan",
            "Joe",
            "Jordan",
            "Billy",
            "Bruce",
            "Albert",
            "Willie",
            "Gabriel",
            "Logan",
            "Alan",
            "Juan",
            "Wayne",
            "Roy",
            "Ralph",
            "Randy",
            "Eugene",
            "Vincent",
            "Russell",
            "Elijah",
            "Louis",
            "Bobby",
            "Philip",
            "Johnny",
            "Mary",
            "Patricia",
            "Jennifer",
            "Linda",
            "Elizabeth",
            "Barbara",
            "Susan",
            "Jessica",
            "Sarah",
            "Karen",
            "Nancy",
            "Lisa",
            "Betty",
            "Margaret",
            "Sandra",
            "Ashley",
            "Kimberly",
            "Emily",
            "Donna",
            "Michelle",
            "Dorothy",
            "Carol",
            "Amanda",
            "Melissa",
            "Deborah",
            "Stephanie",
            "Rebecca",
            "Sharon",
            "Laura",
            "Cynthia",
            "Kathleen",
            "Amy",
            "Shirley",
            "Angela",
            "Helen",
            "Anna",
            "Brenda",
            "Pamela",
            "Nicole",
            "Emma",
            "Samantha",
            "Katherine",
            "Christine",
            "Debra",
            "Rachel",
            "Catherine",
            "Carolyn",
            "Janet",
            "Ruth",
            "Maria",
            "Heather",
            "Diane",
            "Virginia",
            "Julie",
            "Joyce",
            "Victoria",
            "Olivia",
            "Kelly",
            "Christina",
            "Lauren",
            "Joan",
            "Evelyn",
            "Judith",
            "Megan",
            "Cheryl",
            "Andrea",
            "Hannah",
            "Martha",
            "Jacqueline",
            "Frances",
            "Gloria",
            "Ann",
            "Teresa",
            "Kathryn",
            "Sara",
            "Janice",
            "Jean",
            "Alice",
            "Madison",
            "Doris",
            "Abigail",
            "Julia",
            "Judy",
            "Grace",
            "Denise",
            "Amber",
            "Marilyn",
            "Beverly",
            "Danielle",
            "Theresa",
            "Sophia",
            "Marie",
            "Diana",
            "Brittany",
            "Natalie",
            "Isabella",
            "Charlotte",
            "Rose",
            "Alexis",
            "Kayla"
        };
        string[] lnameArr = new string[] {"Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Garcia",
            "Miller",
            "Davis",
            "Rodriguez",
            "Martinez",
            "Hernandez",
            "Lopez",
            "Gonzales",
            "Wilson",
            "Anderson",
            "Thomas",
            "Taylor",
            "Moore",
            "Jackson",
            "Martin",
            "Lee",
            "Perez",
            "Thompson",
            "White",
            "Harris",
            "Sanchez",
            "Clark",
            "Ramirez",
            "Lewis",
            "Robinson",
            "Walker",
            "Young",
            "Allen",
            "King",
            "Wright",
            "Scott",
            "Torres",
            "Nguyen",
            "Hill",
            "Flores",
            "Green",
            "Adams",
            "Nelson",
            "Baker",
            "Hall",
            "Rivera",
            "Campbell",
            "Mitchell",
            "Carter",
            "Roberts",
            "Gomez",
            "Phillips",
            "Evans",
            "Turner",
            "Diaz",
            "Parker",
            "Cruz",
            "Edwards",
            "Collins",
            "Reyes",
            "Stewart",
            "Morris",
            "Morales",
            "Murphy",
            "Cook",
            "Rogers",
            "Gutierrez",
            "Ortiz",
            "Morgan",
            "Cooper",
            "Peterson",
            "Bailey",
            "Reed",
            "Kelly",
            "Howard",
            "Ramos",
            "Kim",
            "Cox",
            "Ward",
            "Richardson",
            "Watson",
            "Brooks",
            "Chavez",
            "Wood",
            "James",
            "Bennet",
            "Gray",
            "Mendoza",
            "Ruiz",
            "Hughes",
            "Price",
            "Alvarez",
            "Castillo",
            "Sanders",
            "Patel",
            "Myers",
            "Long",
            "Ross",
            "Foster",
            "Jimenez"
        };
        string[] streetNamesArr = new string[]
        {
            "Main St",
            "2nd St",
            "3rd St",
            "1st St",
            "Oak St",
            "4th St",
            "Elm St",
            "Pine St",
            "Church St",
            "Maple St",
            "Walnut St",
            "5th St",
            "N Main St",
            "S Main St",
            "Washington St",
            "6th St",
            "E Main St",
            "W Main St",
            "Center St",
            "High St",
            "Park Ave",
            "Cedar St",
            "North St",
            "7th St",
            "Park St",
            "Sunset Dr",
            "River Rd",
            "South St",
            "Chestnut St",
            "Ridge Rd",
            "Mill St",
            "Cherry St",
            "Lakeview Dr",
            "Spring St",
            "Railroad St",
            "Meadow Ln",
            "School St",
            "Circle Dr",
            "West St",
            "8th St",
            "Spruce St",
            "2nd Ave",
            "1st Ave",
            "Jackson St",
            "Shady Ln",
            "Jefferson St",
            "Hill St",
            "Lincoln St",
            "3rd Ave",
            "Short St",
            "Count",
            "Railroad Ave",
            "Water St",
            "Maple Ave",
            "9th St",
            "Locust St",
            "Ash St",
            "Poplar St",
            "County Line Rd",
            "Airport Rd",
            "Central Ave",
            "Front St",
            "Willow St",
            "Highland Ave",
            "Hillcrest Dr",
            "Woodland Dr",
            "East St",
            "Franklin St",
            "Cedar Ln",
            "10th St",
            "Adams St",
            "Vine St",
            "Washington Ave",
            "4th Ave",
            "W 2nd St",
            "Lincoln Ave",
            "Birch St",
            "W 3rd St",
            "Grove St",
            "E 3rd St",
            "Hillside Dr",
            "Grant St",
            "E 2nd St",
            "Pearl St",
            "Smith Rd",
            "State St",
            "5th Ave",
            "Charles St",
            "W 4th St",
            "Hickory St",
            "N 2nd St",
            "N 3rd St",
            "Dogwood Ln",
            "Hickory Ln",
            "Green St",
            "Riverside Dr",
            "Cemetery Rd",
            "James St",
            "Smith St",
            "Fairway Dr",
            "E 4th St"

        };
        string[] professions = new string[]
        {
            "Cashier",
            "Food preparation worker",
            "Janitor",
            "Bartender",
            "Server",
            "Retail sales associate",
            "Stocking associate",
            "Laborer",
            "Customer service representative",
            "Line supervisor",
            "Construction worker",
            "Mechanic",
            "Carpenter",
            "Electrician",
            "Truck Driver"
        };

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var location in zips)
            {
                string url = "https://career4.successfactors.com/career?company=KLGProduction&site=&lang=en_US&requestParams=&login_ns=register&jobPipeline=Reddit&clientId=jobs2web&navBarLevel=MY%5fPROFILE&_s.crb=9F613EBsDhwpCqAbc1SxMVT2%2feRordct1M%2bBmJT3E1Q%3d";
                driver.Navigate().GoToUrl("https://career4.successfactors.com/career?company=KLGProduction&site=&lang=en_US&requestParams=&login_ns=register&jobPipeline=Reddit&clientId=jobs2web&navBarLevel=MY%5fPROFILE&_s.crb=9F613EBsDhwpCqAbc1SxMVT2%2feRordct1M%2bBmJT3E1Q%3d");

                string fname = fnameArr[rndNum(1, 199)];
                string lname = lnameArr[rndNum(1, 100)];
                string rnd = rndNum(0, 9999).ToString();

                while (usedNames.Contains(fname + lname + rnd) == true)
                {
                    fname = fnameArr[rndNum(1, 200)];
                    lname = lnameArr[rndNum(1, 100)];
                    rnd = rndNum(0, 9999).ToString();
                }

                usedNames.Add(fname + lname);



                email = fname + lname + rnd + "@gmail.com";

                driver.FindElement(By.Id("fbclc_userName")).SendKeys(email);
                driver.FindElement(By.Id("fbclc_emailConf")).SendKeys(email);
                driver.FindElement(By.Id("fbclc_pwd")).SendKeys(pass);
                driver.FindElement(By.Id("fbclc_pwdConf")).SendKeys(pass);
                driver.FindElement(By.Id("fbclc_fName")).SendKeys(fname);
                driver.FindElement(By.Id("fbclc_lName")).SendKeys(lname);

                driver.FindElement(By.Id("fbclc_ituCode")).SendKeys("United States");
                string phonenum = rndNum(2, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString() + rndNum(0, 9).ToString();
                driver.FindElement(By.Id("fbclc_phoneNumber")).SendKeys(phonenum);
                driver.FindElement(By.Id("fbclc_country")).SendKeys("United States");
                driver.FindElement(By.XPath("//*[@id='dataPrivacyId']")).Click();
                waitForElement("//*[@id='19:_dialogTitle']", "Data Privacy Consent Statement");
                driver.FindElement(By.XPath("//*[@id='dlgButton_20:']")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id='fbclc_createAccountButton']")).Click();
                waitForElement("//*[@id='pageTitle_']", "Candidate Profile");

                driver.FindElement(By.XPath("//*[@id='30:_expandAllSections']")).Click();
                driver.FindElement(By.XPath("//*[@id='69:_txtFld']")).SendKeys(streetNamesArr[rndNum(0, 99)]);
                driver.FindElement(By.XPath("//*[@id='73:_txtFld']")).SendKeys(location.Location);
                driver.FindElement(By.XPath("//*[@id='81:_txtFld']")).SendKeys(location.code);
                driver.FindElement(By.XPath("//*[@id='85:_select']")).SendKeys(location.state);
                driver.FindElement(By.XPath("//*[@id='101:_txtFld']")).SendKeys(professions[rndNum(0, 14)]);
                driver.FindElement(By.XPath("//*[@id='48:_attachLabel']")).Click();
                waitForElement("//*[@id='49:_uploadComputer']", "Upload from Device");

                //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                //js.ExecuteScript(@"document.querySelector('#\\34 9\\:_file').click();");

                //WebElement browse = driver.FindElement(By.XPath("//*[@id='49:_file']"));

                string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                var directory = System.IO.Path.GetDirectoryName(path);
                string dir = directory.ToString();

                string resumepath = dir + @"\RESUME.docx";

                driver.FindElement(By.XPath("//*[@id='49:_file']")).SendKeys(resumepath);
                //driver.FindElement(By.XPath("//html/body/div[2]/div/div/div/div[2]/div/div/div/div[2]/div/div/div/div[1]/span[2]/input")).Click();
                waitForElement("//*[@id='48:_ariaAttachLabel']", "Document Download");

                Thread.Sleep(15000);

                driver.FindElement(By.XPath("//*[@id='133:_saveBtn']")).Click();

                Thread.Sleep(5000);

                driver.Navigate().GoToUrl(location.link);
                waitForElement("//*[@id='spinner-label']", "Send me alerts every");

                driver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div/div[1]/div[1]/div/div/button")).Click();
                driver.FindElement(By.XPath("//*[@id='applyOption-top-manual']")).Click();

                waitForElement("//*[@id='29:']/p[1]", "We will contact you if we");
                Thread.Sleep(1000);


                driver.FindElement(By.XPath("//*[@id='30:_expandAllSections']")).Click();
                driver.FindElement(By.XPath("//*[@id='154:_select']")).SendKeys("Yes");
                driver.FindElement(By.XPath("//*[@id='195:_select']")).SendKeys("United States");
                driver.FindElement(By.XPath("//*[@id='211:_select']")).SendKeys("Yes");
                driver.FindElement(By.XPath("//*[@id='215:_select']")).SendKeys("No");
                driver.FindElement(By.XPath("//*[@id='219:_select']")).SendKeys("No");
                driver.FindElement(By.XPath("//*[@id='223:_select']")).SendKeys("No");
                driver.FindElement(By.XPath("//*[@id='227:_select']")).SendKeys("Yes");
                driver.FindElement(By.XPath("//*[@id='231:_select']")).SendKeys("Yes");
                driver.FindElement(By.XPath("//*[@id='235:_select']")).SendKeys("Male");

                driver.FindElement(By.XPath("//*[@id='121:_anchorButton']/span")).Click();
                driver.FindElement(By.XPath("//*[@id='127:_anchorButton']/span")).Click();
                driver.FindElement(By.XPath("//*[@id='137:_anchorButton']/span")).Click();
                driver.FindElement(By.XPath("//*[@id='143:_anchorButton']/span")).Click();

                driver.FindElement(By.XPath("//*[@id='172:_txtFld']")).SendKeys("$" + rndNum(15, 25).ToString() + "." + rndNum(0, 99).ToString());

                driver.FindElement(By.XPath("//*[@id='261:_submitBtn']")).Click();

                waitForElement("//*[@id='applyConfirmMsg']/p[1]/span/span/span", "Your application has been sent.");
                Thread.Sleep(1000);


                counter++;

                string countstr = counter.ToString();
                while (countstr.Length < 7)
                {
                    countstr = "0" + countstr;
                }
                lblCounter.Invoke((MethodInvoker)delegate {
                    lblCounter.Text = countstr;
                    lblCounter.Refresh();
                });
                //*[@id='rcmJobApplicationCtr']/div[1]/div[2]/div[2]
                driver.FindElement(By.XPath("//*[@id='rcmJobApplicationCtr']/div[1]/div[2]/div[2]")).Click();
                waitForElement("//*[@id='pageTitle_']", "Candidate Profile");
                Thread.Sleep(1000);
                //*[@id='_signout']
                driver.FindElement(By.XPath("//*[@id='_signout']")).Click();
                //*[@id='page_content']/div[2]/div/div/div[1]/h1
                waitForElement("//*[@id='page_content']/div[2]/div/div/div[1]/h1", "Career Opportunities: Sign In");

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.CancelAsync();
        }
    }
}
