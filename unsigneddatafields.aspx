<%@ Page Language="C#" AutoEventWireup="true" CodeFile="unsigneddatafields.aspx.cs" Inherits="secureacceptance.WebForm1" %>

<html>
<head>
    <title>Unsigned Data Fields</title>
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap-theme.min.css">
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
    
    <link rel="stylesheet" type="text/css" href="Styles/caes.css"/>
    <link rel="stylesheet" type="text/css" href="Styles/site.css"/>
    <link rel="stylesheet" type="text/css" href="Styles/custom.css"/>
    <link rel="stylesheet" type="text/css" href="Styles/payment.css"/>

    <script src="//code.jquery.com/jquery-1.11.0.min.js"></script>
    <script src="//netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <form id="payment_confirmation" action="https://testsecureacceptance.cybersource.com/silent/pay" method="post"/>
            <fieldset id="confirmation">
                <legend>Signed Data Fields</legend>
                    <p>These fields have been signed on your server, and a signature has been generated.  This will detect tampering with these values as they pass through the consumers browser to the SASOP endpoint.</p>
                <div>
                    <%
                        foreach (var key in Request.Form.AllKeys)
                        { 
                            Response.Write("<div>");
                            Response.Write("<span class=\"fieldName\">" + key + ":</span><span class=\"fieldValue\">" + Request.Params[key] + "</span>");
                            Response.Write("</div>");
                        }
                    %>
                </div>
            </fieldset>
            <%
                IDictionary<string, string> parameters = new Dictionary<string, string>();
                foreach (var key in Request.Form.AllKeys)
                {
                    Response.Write("<input type=\"hidden\" id=\"" + key + "\" name=\"" + key + "\" value=\"" + Request.Params[key] + "\"/>\n");
                    parameters.Add(key, Request.Params[key]);
                }
                Response.Write("<input type=\"hidden\" id=\"signature\" name=\"signature\" value=\"" + secureacceptance.Security.sign(parameters) + "\"/>\n");
            %>
            <input type="hidden" name="locale" value="en">
            <fieldset>
                <legend>Unsigned Data Fields</legend>  
                <p>Card data fields are posted directly to CyberSource, together with the fields above.  These field names will need to be included in the unsigned_field_names.</p>
                <div id="UnsignedDataSection" class="section">
                <span>Card Type:</span><input type="text" name="card_type"><br/>
                <span>CC Number:</span><input type="text" name="card_number"><br/>
                <span>Exp Date:</span><input type="text" name="card_expiry_date"><br/>
	        </div>
            </fieldset>
          <input type="submit" id="submit" value="Confirm "/>
          <script type="text/javascript" src="Scripts/jquery-1.7.min.js"></script>
          <script type="text/javascript" src="Scripts/payment_form.js"></script>

        </form>
    </div>
</body>
</html>
