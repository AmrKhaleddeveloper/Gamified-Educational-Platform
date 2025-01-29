﻿using System;
using System.Collections.Generic;

namespace Spaghetti.Models;

public partial class ContentLibrary
{
    public int Id { get; set; }

    public int? ModuleId { get; set; }

    public int? CourseId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? MetaData { get; set; }

    public string? Type { get; set; }

    public string? ContentUrl { get; set; }

    public virtual Module? Module { get; set; }
}
