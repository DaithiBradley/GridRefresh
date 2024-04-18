﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DXApplication3.Models;

public partial class LeadEvent
{
    public int Id { get; set; }

    public int? Lid { get; set; }

    public DateTime? Start { get; set; }

    public DateTime? Finish { get; set; }

    public string Service { get; set; }

    public decimal? Wages { get; set; }

    public decimal? Charge { get; set; }

    public decimal? Travel { get; set; }

    public decimal? Profit { get; set; }

    public decimal? Overnight { get; set; }

    public decimal? Subsistence { get; set; }

    public decimal? SubTotalCharge { get; set; }

    public string Remarks { get; set; }

    public string Phase { get; set; }

    public decimal? Hours { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string LeadEventscol { get; set; }

    public decimal? SubTotalCosts { get; set; }
}