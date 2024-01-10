using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innvoice_Services.Models
{
    public class Transaction
    {
        public string SealNo { get; set; }

        public bool? Receiving { get; set; }

        public string BookingNo { get; set; }

        public string Exceptions { get; set; }

        public string Shipper { get; set; }

        public string Destination { get; set; }

        public string Hatch { get; set; }

        public double? CubicMeters { get; set; }

        public float? Height { get; set; }

        public float? Width { get; set; }

        public float? Length { get; set; }

        public string Barge { get; set; }

        public string ItemType { get; set; }

        public int? Items { get; set; }

        public string LotIdentifier { get; set; }

        public string BillOfLading { get; set; }

        public string InOutBound { get; set; }

        public double? NetTons { get; set; }

        public double? MetricTons { get; set; }

        public int? WeightLbs { get; set; }

        public string Cargo { get; set; }

        public string LoadingUnloadingCh { get; set; }

        public string ContainerNumber { get; set; }

        public int? AgentId { get; set; }

        public int? JobId { get; set; }

        public int TransactionId { get; internal set; }
        public string TransactionType { get; internal set; }
        public int? CustomerNumber { get; internal set; }
        public DateTime? ArrivalDt { get; internal set; }
        public DateTime? TimeDocked { get; internal set; }
        public bool Midstream { get; internal set; }
        public string VesselName { get; internal set; }
        public DateTime? ArrivalTime { get; internal set; }
        public DateTime? DepartDt { get; internal set; }
        public DateTime? DepartTime { get; internal set; }
        public DateTime? DtDocked { get; internal set; }
        public DateTime? DtSailed { get; internal set; }
        public DateTime? TimeSailed { get; internal set; }
    }
}