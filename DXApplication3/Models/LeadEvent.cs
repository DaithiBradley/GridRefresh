﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DXApplication3.Models;

[Table("Lead_Events")]
public partial class LeadEvent
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("LID")]
    public int? Lid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Finish { get; set; }

    [StringLength(245)]
    public string Service { get; set; }

    [Precision(10, 2)]
    public decimal? Wages { get; set; }

    [Precision(10, 2)]
    public decimal? Charge { get; set; }

    [Precision(10, 2)]
    public decimal? Travel { get; set; }

    [Precision(10, 2)]
    public decimal? Profit { get; set; }

    [Precision(10, 2)]
    public decimal? Overnight { get; set; }

    [Precision(10, 2)]
    public decimal? Subsistence { get; set; }

    [Precision(10, 2)]
    public decimal? SubTotalCharge { get; set; }

    [StringLength(245)]
    public string Remarks { get; set; }

    [StringLength(245)]
    public string Phase { get; set; }

    [Precision(10, 2)]
    public decimal? Hours { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? TimeStamp { get; set; }

    [Column("Lead_Eventscol")]
    [StringLength(45)]
    public string LeadEventscol { get; set; }

    [Precision(10, 2)]
    public decimal? SubTotalCosts { get; set; }
}