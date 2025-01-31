﻿using BaseProject.Domain.Enums;

namespace BaseProject.Domain.Common.Helpers.Notifications;


public class NotifyModel
{
    public string TextAr { get; set; }
    public string TextEn { get; set; }
    public string UserId { get; set; }
    public NotifyType Type { get; set; }
    public int? ItemId { get; set; }
}