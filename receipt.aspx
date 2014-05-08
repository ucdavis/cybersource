<%@ Page Language="C#" AutoEventWireup="true" CodeFile="receipt.aspx.cs" Inherits="secureacceptance.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
    <title>Secure Acceptance - Payment Form Example</title>
    <link rel="stylesheet" type="text/css" href="/Styles/payment.css"/>
</head>
<body>

<fieldset id="response">
    <legend>Receipt</legend>
    <div>
        <form id="receipt" action="">
            <%
                IDictionary<string, string> parameters = new Dictionary<string, string>();
        
                foreach (var key in Request.Form.AllKeys)
                {                 
                    Response.Write("<span>" + key + "</span><input type=\"text\" name=\"" + key + "\" size=\"50\" value=\"" + Request.Params[key] + "\" readonly=\"true\"/><br/>");
                    parameters.Add(key, Request.Params[key]);
                }

                Response.Write("<span>Signature Verified:</span><input type=\"text\" name=\"verified\" size=\"50\" value=\"" + Request.Params["signature"].Equals(secureacceptance.Security.sign(parameters)) + "\" readonly=\"true\"/><br/>");
            %>
        </form>
    </div>
</fieldset>

</body>
</html>

