using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBD_lab1
{
    public static class ReportQueries
    {
        public static string PartsRemains = @"SELECT devices.Dev_model, repair_parts.Part_name, parts_warehouse.PartWH_count, parts_warehouse.PartWH_sum
FROM     parts_warehouse INNER JOIN
                  devices ON parts_warehouse.Dev_id = devices.Dev_id INNER JOIN
                  repair_parts ON parts_warehouse.Part_id = repair_parts.Part_id";
        public static string CurrentOrders = @"SELECT DISTINCT employees.Empl_surname, employees.Empl_name, employees.Empl_second_name, orders.Ord_id, orders.Ord_datetime
FROM     order_devices INNER JOIN
                  orders ON order_devices.Ord_id = orders.Ord_id INNER JOIN
                  employees ON orders.Empl_id = employees.Empl_id
WHERE  (order_devices.OrdDev_fixed = 0)";
        public static string CompletedOrders = @"SELECT DISTINCT employees.Empl_surname, employees.Empl_name, employees.Empl_second_name, orders.Ord_id, orders.Ord_datetime, orders.Ord_sum
FROM     orders INNER JOIN
                  order_devices ON orders.Ord_id = order_devices.Ord_id INNER JOIN
                  employees ON orders.Empl_id = employees.Empl_id
WHERE  (order_devices.OrdDev_fixed = 1) AND (orders.Ord_datetime >= @НачалоПериода) AND (orders.Ord_datetime < @КонецПериода)";
    }
}
