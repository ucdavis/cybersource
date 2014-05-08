<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeFile="signeddatafields.aspx.cs" Inherits="secureacceptance._Default" %>

<html>
<head>
    <title>Signed Data Fields</title>
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
        <form id="payment_form" action="unsigneddatafields.aspx" method="post" onsubmit="submit_signed()">
            <input type="hidden" name="access_key" value="fd0f49af2d2d3e2e9abcf26be03e3215">
            <input type="hidden" name="profile_id" value="59NXqwQ">
            <input type="hidden" name="transaction_uuid" value="<% Response.Write(getUUID()); %>">
            <input type="hidden" name="signed_field_names" value="access_key,profile_id,transaction_uuid,signed_field_names,unsigned_field_names,signed_date_time,locale,transaction_type,reference_number,amount,recurring_frequency,recurring_amount,currency,payment_method,bill_to_forename,bill_to_surname,bill_to_email,bill_to_phone,bill_to_address_line1,bill_to_address_city,bill_to_address_state,bill_to_address_country,bill_to_address_postal_code">
            <input type="hidden" name="unsigned_field_names" value="card_type,card_number,card_expiry_date">
            <input type="hidden" name="signed_date_time" value="<% Response.Write(getUTCDateTime()); %>">
            <input type="hidden" name="locale" value="en">
            <input type="hidden" name="transaction_type" value="authorization">
            <input type="hidden" name="reference_number">
            <input type="hidden" name="payment_method" value="card"><br/>
            <input type="hidden" name="currency" value="USD"><br/>
            <fieldset>
                <legend>Signed Data Fields</legend>
                <p>These fields will be POSTed to your server for signing using the Security file included in the sample script.</p><br/>
                <div id="paymentDetailsSection" class="section">
                    <h2>Gift Info:</h2>
                    <span>One time gift?:</span><input type="checkbox" id="gifttype" onchange="set_gifttype()" />
                    <div id="onetime">
                        <span>Amount (USD):</span><input type="text" name="amount"><br/>
                    </div>
                    <div id="subscription">
                        <span>Amount (USD):</span><input type="text" name="recurring_amount"><br/>
                        <span>Frequency:</span><input type="text" name="recurring_frequency"><br/>
                    </div>
                    <h2>Customer Info:</h2>
                    <span>First:</span><input type="text" name="bill_to_forename"><br/>
                    <span>Last:</span><input type="text" name="bill_to_surname"><br/>
                    <span>Email:</span><input type="text" name="bill_to_email"><br/>
                    <span>Phone:</span><input type="text" name="bill_to_phone"><br/>
                    <h2>Billing Info:</h2>
                    <span>Street Address:</span><input type="text" name="bill_to_address_line1"><br/>
                    <span>City:</span><input type="text" name="bill_to_address_city"><br/>
                    <span>State:</span><input type="text" name="bill_to_address_state"><br/>
                    <span>Country:</span><input type="text" name="bill_to_address_country"><br/>
                    <span>Postal Code:</span><input type="text" name="bill_to_address_postal_code"><br/>
                </div>
            </fieldset>
            <input type="submit" id="submit" name="submit" value="Submit"/>
            <script type="text/javascript" src="Scripts/payment_form.js"></script>
        </form>
    </div>
</body>
</html>
