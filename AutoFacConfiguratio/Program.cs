using Autofac;
using Store.IntegrationServices;
using System;

namespace AutoFacConfiguration
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool running = true;
            IContainer container = GetAutoWiredApp();
            using (var scope = container.BeginLifetimeScope())
                {
                Store.Sales.SalesUI.ConsoleSalesUI salesUi = scope.Resolve<Store.Sales.SalesUI.ConsoleSalesUI>();
                Store.Marketing.MarketingUI.ConsoleMarketingUI marketingUi = scope.Resolve<Store.Marketing.MarketingUI.ConsoleMarketingUI>();
                Store.Production.ProductionUI.ConsoleProductionUI productionUi = scope.Resolve<Store.Production.ProductionUI.ConsoleProductionUI>();

                do
                    {
                    Console.WriteLine(GetMenuMessage());
                    string choise = Console.ReadLine();

                    switch (choise)
                        {
                        case "1":
                            salesUi.RegisterCustomer();
                            break;
                        case "2":
                            salesUi.PlaceOrder();
                            break;
                        case "3":
                            salesUi.CancelOrder();
                            break;
                        case "4":
                            productionUi.OpenWarehouse();
                            break;
                        case "5":
                            productionUi.AddPhone();
                            break;
                        case "6":
                            productionUi.GetPhoneQuantity();
                            break;
                        case "7":
                            productionUi.GetTransportationPrice();
                            break;
                        case "8":
                            marketingUi.AddAdvertisment();
                            break;
                        case "9":
                            marketingUi.AddCampaign();
                            break;
                        case "10":
                            marketingUi.CancelAdvertisment();
                            break;
                        case "0":
                            running = false;
                            break;
                        default:
                            break;
                        }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    } while (running);
                }
            }

        static String GetMenuMessage()
            {
            return "\n\nSales:\n" +
                    "  1 - Register new customer\n" +
                    "  2 - Place new order\n" +
                    "  3 - Cancel order\n" +
                    "\nProduction:\n" +
                    "  4 - Open warehouse\n" +
                    "  5 - Add phone to production\n" +
                    "  6 - Get phones quantity\n" +
                    "  7 - Get transportation price\n" +
                    "\nMarketing:\n" +
                    "  8 - Add advertisment\n" +
                    "  9 - Add campaign\n" +
                    " 10 - Cancel advertisment\n" +
                    "\n\n  0 - Exit";
            }

        static IContainer GetAutoWiredApp()
            {
            ContainerBuilder builder = new ContainerBuilder();

            // registering sales types
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularCustomer>().As<Store.Sales.SalesDomainEntities.ICustomer>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularOrder>().As<Store.Sales.SalesDomainEntities.IOrder>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularSalesFactory>().As<Store.Sales.SalesDomainEntities.ISalesFactory>();
            builder.RegisterType<Store.Sales.SalesDomainServices.RegularPriceCalculator>().As<Store.Sales.SalesDomainServices.IOrderPriceCalculator>();
            builder.RegisterType<Store.Sales.SalesFacadeService.SalesFacadeImplementation>().As<Store.Sales.SalesFacadeService.ISalesFacade>();
            builder.RegisterType<ReliableEmailService>().As<Store.Sales.SalesFacadeService.IEmailSender>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryCustomerRepository>().As<Store.Sales.SalesFacadeService.ICustomerRepository>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryOrderRepository>().As<Store.Sales.SalesFacadeService.IOrderRepository>();
            builder.RegisterType<Store.Sales.SalesController.SalesControllerImplementation>().As<Store.Sales.SalesController.ISalesController>();
            builder.RegisterType<Store.Sales.SalesUI.ConsoleSalesUI>();

            // registering production types
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalPhone>().As<Store.Production.ProductionDomainEntities.IPhone>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalWarehouse>().As<Store.Production.ProductionDomainEntities.IWarehouse>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalProductionFactory>().As<Store.Production.ProductionDomainEntities.IProductionFactory>();
            builder.RegisterType<Store.Production.ProductionDomainServices.DemoPhonesSupplier>().As<Store.Production.ProductionDomainServices.IPhoneSupplier>();
            builder.RegisterType<Store.Production.ProductionDomainServices.LegalImportFeeCalculator>().As<Store.Production.ProductionDomainServices.IImportFeeCalculator>();
            builder.RegisterType<Store.Production.ProductionFacadeService.ProductionFacadeImplementation>().As<Store.Production.ProductionFacadeService.IProductionFacade>();
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryPhoneRepository>().As<Store.Production.ProductionFacadeService.IPhoneRepository>();
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryWarehouseRepository>().As<Store.Production.ProductionFacadeService.IWarehouseRepository>();
            builder.RegisterType<Store.Production.ProductionController.ProductionControllerImplementation>().As<Store.Production.ProductionController.IProductionController>();
            builder.RegisterType<Store.Production.ProductionUI.ConsoleProductionUI>();

            // registering marketing types
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioAdvertisment>().As<Store.Marketing.MarketingDomainEntities.IAdvertisment>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioCampaign>().As<Store.Marketing.MarketingDomainEntities.ICampaign>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioMarketingFactory>().As<Store.Marketing.MarketingDomainEntities.IMarketingFactory>();
            builder.RegisterType<Store.Marketing.MarketingDomainServices.SwearWordFilter>().As<Store.Marketing.MarketingDomainServices.IAdvertismentFilter>();
            builder.RegisterType<Store.Marketing.MarketingFacadeService.MarketingFacadeImplementation>().As<Store.Marketing.MarketingFacadeService.IMarketingFacade>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryAdvertismentRepository>().As<Store.Marketing.MarketingFacadeService.IAdvertismentRepository>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryCampaignRepository>().As<Store.Marketing.MarketingFacadeService.ICampaignRepository>();
            builder.RegisterType<Store.Marketing.MarketingController.MarketingControllerImplementation>().As<Store.Marketing.MarketingController.IMarketingController>();
            builder.RegisterType<Store.Marketing.MarketingUI.ConsoleMarketingUI>();
            return builder.Build();
            }
        }
    }
