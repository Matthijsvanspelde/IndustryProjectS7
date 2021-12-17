using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailModel 
{
    private string header;
    private string mailText;

    public string Header { get => header; set => header = value; }
    public string MailText { get => mailText; set => mailText = value; }

    public string ResponedText { get; set; }

    public MailModel (string header,string mailText)
    {
        this.header = header;
        this.mailText = mailText;
    }
}
