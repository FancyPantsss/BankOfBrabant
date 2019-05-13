using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfBrabant.Models;
using MySql.Data.MySqlClient;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfBrabant.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult CreateAccount()
        {      
            return View();
        }

        public ActionResult CreateButton(String accountType, int PassNumber, string AccountName, int PinCode)
        {
            SQLManager sqm = SQLManager.Initialize("94.208.132.186", "23412", "testdb", "user02", "X7f6EysG8jrgNQvp");

            if (PassNumber != 0 & !String.IsNullOrEmpty(AccountName))
            {
                if (CheckDatabase(PassNumber, AccountName))
                {
                    if (accountType.Equals("depositAccount"))
                    {
                        AccountAbstract account = new DepositAccount(500, 1, 6, PassNumber, PinCode, AccountName);
                        ViewBag.Message = accountType;
                        return View(account);
                    }
                    else if (accountType.Equals("savingsAccount"))
                    {
                        AccountAbstract account = new SavingsAccount(500, 1, 5, PassNumber, PinCode, AccountName);
                        ViewBag.Message = account.AccountName;
                        System.Diagnostics.Debug.WriteLine(account.PassNumber);
                        return View(account);
                    }
                    else
                    {
                        AccountAbstract account = new SpendingAccount(500, 1, 7, PassNumber, PinCode, AccountName);
                        ViewBag.Message = accountType;
                        return View(account);
                    }
                }

                //Functions functionController = DependencyResolver.Current.GetService<Functions>();
                //functionController.ControllerContext = new ControllerContext(this.Request.RequestContext, functionController);

                else
                {
                    ViewBag.Message = "This account name is already in use, please choose another one.";
                    //CreateAccount();
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Please fill in your passnumber and desired account name.";
                //View() = CreateAccount();
                return View();
            }
        }

        //check of account name of pasnummer correct zijn
        public bool CheckDatabase(int passnumber, string accountname)
        {
            if(5 == 5)
            {
                return true;
            }
            else
            {

            }
           // return false;
        }
    }
}
