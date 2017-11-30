using Autofac;
using Autofac.Core;
using Store.IntegrationServices;
using System;

namespace AutoFacConfiguration
    {
    class Program
        {
        static void Main(string[] args)
            {
            bool running = true;
            IContainer container = Delivery2();
            using (var scope = container.BeginLifetimeScope())
                {
                Store.Sales.SalesUI.ConsoleSalesUI salesUi = scope.Resolve<Store.Sales.SalesUI.ConsoleSalesUI>();
                Store.Marketing.MarketingUI.ConsoleMarketingUI marketingUi = scope.Resolve<Store.Marketing.MarketingUI.ConsoleMarketingUI>();
                Store.Production.ProductionUI.ConsoleProductionUI productionUi = scope.Resolve<Store.Production.ProductionUI.ConsoleProductionUI>();

                do
                    {
                    Console.Clear();
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
                            productionUi.GetTransportationPrice();
                            break;
                        case "7":
                            marketingUi.AddAdvertisment();
                            break;
                        case "8":
                            marketingUi.AddCampaign();
                            break;
                        case "9":
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
            return "Sales:\n" +
                    "  1 - Register new customer\n" +
                    "  2 - Place new order\n" +
                    "  3 - Cancel order\n" +
                    "\nProduction:\n" +
                    "  4 - Open new warehouse\n" +
                    "  5 - Add phone to production\n" +
                    "  6 - Get transportation price\n" +
                    "\nMarketing:\n" +
                    "  7 - Add advertisment\n" +
                    "  8 - Add campaign\n" +
                    "  9 - Cancel advertisment\n" +
                    "\n\n  0 - Exit";
            }

        static IContainer Delivery1()
            {
            ContainerBuilder builder = new ContainerBuilder();

            // registering sales types
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularCustomer>().As<Store.Sales.SalesDomainEntities.ICustomer>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularOrder>().As<Store.Sales.SalesDomainEntities.IOrder>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.RegularSalesFactory>().As<Store.Sales.SalesDomainEntities.ISalesFactory>();
            builder.RegisterType<Store.Sales.SalesDomainServices.RegularPriceCalculator>().As<Store.Sales.SalesDomainServices.IOrderPriceCalculator>();
            builder.RegisterType<Store.Sales.SalesFacadeService.SalesFacadeWithoutIntegration>().As<Store.Sales.SalesFacadeService.ISalesFacade>();
            builder.RegisterType<ReliableEmailService>().As<Store.IntegrationServices.IEmailSender>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryCustomerRepository>().As<Store.Sales.SalesRepository.ICustomerRepository>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryOrderRepository>().As<Store.Sales.SalesRepository.IOrderRepository>();
            builder.RegisterType<Store.Sales.SalesController.SalesControllerImplementation>().As<Store.Sales.SalesController.ISalesController>();
            builder.RegisterType<Store.Sales.SalesUI.ConsoleSalesUI>().AsSelf();

            // registering production types
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalPhone>().As<Store.Production.ProductionDomainEntities.IPhone>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalWarehouse>().As<Store.Production.ProductionDomainEntities.IWarehouse>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.LocalProductionFactory>().As<Store.Production.ProductionDomainEntities.IProductionFactory>();
            builder.RegisterType<Store.Production.ProductionDomainServices.DemoPhonesSupplier>().As<Store.Production.ProductionDomainServices.IPhoneSupplier>();
            builder.RegisterType<Store.Production.ProductionDomainServices.LegalImportFeeCalculator>().As<Store.Production.ProductionDomainServices.IImportFeeCalculator>();
            builder.RegisterType<Store.Production.ProductionFacadeService.ProductionFacadeWithoutNotifier>().As<Store.Production.ProductionFacadeService.IProductionFacade>();
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryPhoneRepository>().As<Store.Production.ProductionRepository.IPhoneRepository>();
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryWarehouseRepository>().As<Store.Production.ProductionRepository.IWarehouseRepository>();
            builder.RegisterType<Store.Production.ProductionController.ProductionControllerImplementation>().As<Store.Production.ProductionController.IProductionController>();
            builder.RegisterType<Store.IntegrationServices.PhoneAdministratorNotifier>().As<Store.Production.ProductionDomainServices.IPhonesSuppliedListener>();
            builder.RegisterType<Store.Production.ProductionUI.ConsoleProductionUI>().AsSelf();

            // registering marketing types
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioAdvertisment>().As<Store.Marketing.MarketingDomainEntities.IAdvertisment>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioCampaign>().As<Store.Marketing.MarketingDomainEntities.ICampaign>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.RadioMarketingFactory>().As<Store.Marketing.MarketingDomainEntities.IMarketingFactory>();
            builder.RegisterType<Store.Marketing.MarketingDomainServices.SwearWordFilter>().As<Store.Marketing.MarketingDomainServices.IAdvertismentFilter>();
            builder.RegisterType<Store.Marketing.MarketingFacadeService.MarketingFacadeWithoutAdFiltering>().As<Store.Marketing.MarketingFacadeService.IMarketingFacade>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryAdvertismentRepository>().As<Store.Marketing.MarketingRepository.IAdvertismentRepository>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryCampaignRepository>().As<Store.Marketing.MarketingRepository.ICampaignRepository>();
            builder.RegisterType<Store.Marketing.MarketingController.MarketingControllerImplementation>().As<Store.Marketing.MarketingController.IMarketingController>();
            builder.RegisterType<Store.Marketing.MarketingUI.ConsoleMarketingUI>().AsSelf();
            return builder.Build();
            }

        static IContainer Delivery2()
            {
            ContainerBuilder builder = new ContainerBuilder();

            // registering sales types
            builder.RegisterType<Store.Sales.SalesDomainEntities.LoyalCustomer>().As<Store.Sales.SalesDomainEntities.ICustomer>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.DiscountedOrder>().As<Store.Sales.SalesDomainEntities.IOrder>();
            builder.RegisterType<Store.Sales.SalesDomainEntities.DiscountedSalesFactory>().As<Store.Sales.SalesDomainEntities.ISalesFactory>();
            builder.RegisterType<Store.Sales.SalesDomainServices.BigSalePriceCalculator>().As<Store.Sales.SalesDomainServices.IOrderPriceCalculator>();
            builder.RegisterType<Store.Sales.SalesFacadeService.SalesFacadeWithIntegration>().As<Store.Sales.SalesFacadeService.ISalesFacade>();
            builder.RegisterType<ReliableEmailService>().As<Store.IntegrationServices.IEmailSender>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryCustomerRepository>().As<Store.Sales.SalesRepository.ICustomerRepository>();
            builder.RegisterType<Store.Sales.SalesRepository.InMemoryOrderRepository>().As<Store.Sales.SalesRepository.IOrderRepository>();
            builder.RegisterType<Store.Sales.SalesController.SalesControllerImplementation>().As<Store.Sales.SalesController.ISalesController>();
            builder.RegisterType<Store.Sales.SalesUI.ConsoleSalesUI>().AsSelf();

            // registering production types
            builder.RegisterType<Store.Production.ProductionDomainEntities.AbroadPhone>().As<Store.Production.ProductionDomainEntities.IPhone>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.AbroadWarehouse>().As<Store.Production.ProductionDomainEntities.IWarehouse>();
            builder.RegisterType<Store.Production.ProductionDomainEntities.AbroadProductionFactory>().As<Store.Production.ProductionDomainEntities.IProductionFactory>();
            builder.RegisterType<Store.Production.ProductionDomainServices.RealPhonesSupplier>().As<Store.Production.ProductionDomainServices.IPhoneSupplier>().WithParameter(ResolvedParameter.ForNamed< Store.Production.ProductionDomainServices.IPhonesSuppliedListener>("PhoneNotifier"));
            builder.RegisterType<Store.Production.ProductionDomainServices.LegalImportFeeCalculator>().As<Store.Production.ProductionDomainServices.IImportFeeCalculator>();
            builder.RegisterType<Store.Production.ProductionFacadeService.ProductionFacadeWithNotifier>().As<Store.Production.ProductionFacadeService.IProductionFacade>().WithParameter(ResolvedParameter.ForNamed<Store.Production.ProductionDomainServices.IPhonesSuppliedListener>("EmailNotifier"));
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryPhoneRepository>().As<Store.Production.ProductionRepository.IPhoneRepository>();
            builder.RegisterType<Store.Production.ProductionRepository.InMemoryWarehouseRepository>().As<Store.Production.ProductionRepository.IWarehouseRepository>();
            builder.RegisterType<Store.Production.ProductionController.ProductionControllerImplementation>().As<Store.Production.ProductionController.IProductionController>();
            builder.RegisterType<Store.IntegrationServices.EmailAdministratorNotifier>().As<Store.Production.ProductionDomainServices.IPhonesSuppliedListener>();
            builder.RegisterType<Store.Production.ProductionUI.ConsoleProductionUI>().AsSelf();

            // registering marketing types
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.TVAdvertisment>().As<Store.Marketing.MarketingDomainEntities.IAdvertisment>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.TVCampaign>().As<Store.Marketing.MarketingDomainEntities.ICampaign>();
            builder.RegisterType<Store.Marketing.MarketingDomainEntities.TVMarketingFactory>().As<Store.Marketing.MarketingDomainEntities.IMarketingFactory>();
            builder.RegisterType<Store.Marketing.MarketingDomainServices.SwearWordFilter>().As<Store.Marketing.MarketingDomainServices.IAdvertismentFilter>();
            builder.RegisterType<Store.Marketing.MarketingFacadeService.MarketingFacadeWithAdFiltering>().As<Store.Marketing.MarketingFacadeService.IMarketingFacade>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryAdvertismentRepository>().As<Store.Marketing.MarketingRepository.IAdvertismentRepository>();
            builder.RegisterType<Store.Marketing.MarketingRepository.InMemoryCampaignRepository>().As<Store.Marketing.MarketingRepository.ICampaignRepository>();
            builder.RegisterType<Store.Marketing.MarketingController.MarketingControllerImplementation>().As<Store.Marketing.MarketingController.IMarketingController>();
            builder.RegisterType<Store.Marketing.MarketingUI.ConsoleMarketingUI>().AsSelf();
            return builder.Build();
            }
        }
    }
