﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Ariansen.Models;

namespace Ariansen.Models
{
    public class Category
    {
    }
}

public class Category : RecursiveEntity<Category>
{
    /// <summary>
    ///     Gets or sets the name of the category.
    /// </summary>
    /// <value>
    ///     The name of the category.
    /// </value>
    public string Name { get; set; }

}