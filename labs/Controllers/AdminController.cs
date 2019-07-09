using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using labs.Models;
using labs.ModelView;
using labs.Dal;
using System.Threading;


namespace labs.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        public ActionResult GetProductsByJson()
        {
            DataLayers dal = new DataLayers();
            Thread.Sleep(3000);
            List<Product> objProducts = dal.Products.ToList<Product>();

            return Json(objProducts, JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        //AddPerfume is addressing to the form to get data from the user
        public ActionResult AddPerfume()
        {
            DataLayers dal = new DataLayers();
            List<Product> objProducts = dal.Products.ToList<Product>();
            ProductViewModel cvm = new ProductViewModel();
            cvm.Product = new Product();
            cvm.Products = objProducts;

            return View("AddPerfume", cvm);
        }

        //we get the data from the form that the user filled (Product.cshtml) the data is passed to the Product controller
        //and the object that was created (cust) we send to Product view (strongly typed view-works with Product model)
        /*we can pass an object to the function instead of writing all the things below and that because all the named in the html page are identical to fields in the Product model/class */

        
        [HttpPost]
        public ActionResult SubmitProduct()
        {
            Product objProduct = new Product();
            objProduct.ProductNumber = Request.Form["Product.ProductNumber"].ToString();
            objProduct.ProductName = Request.Form["Product.ProductName"].ToString();
            objProduct.ProductCost = Request.Form["Product.ProductCost"].ToString();
            objProduct.ProductQuantity = Request.Form["Product.ProductQuantity"].ToString();

            DataLayers dal = new DataLayers();

            if (ModelState.IsValid)
            {
                try
                {

                    dal.Products.Add(objProduct);//in memory adding only
                    dal.SaveChanges();
                }
                catch (Exception)
                {
                    TempData["error"] = "The product already exist!\n"; // print error message
                    return View();
                }

            }
            List<Product> objProducts = dal.Products.ToList<Product>();
            Thread.Sleep(3000);
            return Json(objProducts, JsonRequestBehavior.AllowGet);
        }


        /// //////////////////////////Employee//////////////////////////////////////
        public ActionResult GetEmployeesByJson()
        {
            DataLayers dal = new DataLayers();
            Thread.Sleep(3000);
            List<Employee> objEmployees = dal.Employees.ToList<Employee>();

            return Json(objEmployees, JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        //AddPerfume is addressing to the form to get data from the user
        public ActionResult AddEmployee()
        {
            DataLayers dal = new DataLayers();
            List<Employee> objEmployees = dal.Employees.ToList<Employee>();
            EmployeeViewModel cvm = new EmployeeViewModel();
            cvm.Employee = new Employee();
            cvm.Employees = objEmployees;

            return View("AddEmployee", cvm);
        }

        //we get the data from the form that the user filled (Product.cshtml) the data is passed to the Product controller
        //and the object that was created (cust) we send to Product view (strongly typed view-works with Product model)
        /*we can pass an object to the function instead of writing all the things below and that because all the named in the html page are identical to fields in the Product model/class */

       
        [HttpPost]
        public ActionResult SubmitEmp()
        {
            Employee objEmployee = new Employee();
            objEmployee.EmployeeId = Request.Form["Employee.EmployeeId"].ToString();
            objEmployee.EmployeeName = Request.Form["Employee.EmployeeName"].ToString();
            objEmployee.EmployeeEmail = Request.Form["Employee.EmployeeEmail"].ToString();
            objEmployee.EmployeeAddress = Request.Form["Employee.EmployeeAddress"].ToString();
            objEmployee.EmployeeSalary = Request.Form["Employee.EmployeeSalary"].ToString();
            objEmployee.EmployeeJobTitle = Request.Form["Employee.EmployeeJobTitle"].ToString();

            DataLayers dal = new DataLayers();

            if (ModelState.IsValid)
            {
                try
                {

                    dal.Employees.Add(objEmployee);//in memory adding only
                    dal.SaveChanges();
                }
                catch (Exception)
                {
                    TempData["error"] = "The employee already exist!\n"; // print error message
                    return View();
                }

            }
            List<Employee> objEmployees = dal.Employees.ToList<Employee>();
            Thread.Sleep(3000);
            return Json(objEmployees, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowEmployeeSearch()
        {
            EmployeeViewModel cvm = new EmployeeViewModel();
            cvm.Employees = new List<Employee>();
            return View("SearchEmployee", cvm);//pass model cvm to SearhEmployee cshtml 
        }

        public ActionResult SearchEmployee()
        {
            DataLayers dal = new DataLayers();
            string searchValue = Request.Form["txtEmployeeName"].ToString();
            List<Employee> objEmployees = (from x in dal.Employees
                                         where x.EmployeeName.Contains(searchValue)
                                         select x).ToList<Employee>();
            EmployeeViewModel cvm = new EmployeeViewModel();
            cvm.Employees = objEmployees;

            return View(cvm);


        }


        /// //////////////////////////Supplier//////////////////////////////////////
        public ActionResult GetSuppliersByJson()
        {
            DataLayers dal = new DataLayers();
            Thread.Sleep(3000);
            List<Supplier> objSuppliers = dal.Suppliers.ToList<Supplier>();

            return Json(objSuppliers, JsonRequestBehavior.AllowGet);
        }
        [Authorize]
        //AddPerfume is addressing to the form to get data from the user
        public ActionResult AddSupplier()
        {
            DataLayers dal = new DataLayers();
            List<Supplier> objSuppliers = dal.Suppliers.ToList<Supplier>();
            SupplierViewModel cvm = new SupplierViewModel();
            cvm.Supplier = new Supplier();
            cvm.Suppliers = objSuppliers;

            return View("AddSupplier", cvm);
        }

        //we get the data from the form that the user filled (Product.cshtml) the data is passed to the Product controller
        //and the object that was created (cust) we send to Product view (strongly typed view-works with Product model)
        /*we can pass an object to the function instead of writing all the things below and that because all the named in the html page are identical to fields in the Product model/class */


        [HttpPost]
        public ActionResult SubmitSup()
        {
            Supplier objSupplier = new Supplier();
            objSupplier.SupplierId = Request.Form["Supplier.SupplierId"].ToString();
            objSupplier.SupplierName = Request.Form["Supplier.SupplierName"].ToString();
            objSupplier.SupplierEmail = Request.Form["Supplier.SupplierEmail"].ToString();
            objSupplier.SupplierAddress = Request.Form["Supplier.SupplierAddress"].ToString();
            objSupplier.SupplierPhoneNumber = Request.Form["Supplier.SupplierPhoneNumber"].ToString();

            DataLayers dal = new DataLayers();

            if (ModelState.IsValid)
            {
                try
                {

                    dal.Suppliers.Add(objSupplier);//in memory adding only
                    dal.SaveChanges();
                }
                catch (Exception)
                {
                    TempData["error"] = "The supplier already exist!\n"; // print error message
                    return View();
                }

            }
            List<Supplier> objSuppliers = dal.Suppliers.ToList<Supplier>();
            Thread.Sleep(3000);
            return Json(objSuppliers, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShowSupplierSearch()
        {
            SupplierViewModel cvm = new SupplierViewModel();
            cvm.Suppliers = new List<Supplier>();
            return View("SearchSupplier", cvm);//pass model cvm to SearhEmployee cshtml 
        }

        public ActionResult SearchSupplier()
        {
            DataLayers dal = new DataLayers();
            string searchValue = Request.Form["txtSupplierName"].ToString();
            List<Supplier> objSuppliers = (from x in dal.Suppliers
                                           where x.SupplierName.Contains(searchValue)
                                           select x).ToList<Supplier>();
            SupplierViewModel cvm = new SupplierViewModel();
            cvm.Suppliers = objSuppliers;

            return View(cvm);


        }


        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}

