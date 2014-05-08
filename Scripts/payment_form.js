var payment_form;

$(document).ready(function () {
    payment_form = $('form').attr('id');
    addLinkToSetDefaults();
    set_gifttype();
});

function setDefaultsForAll() {
         if (payment_form === "payment_confirmation"){
      setDefaultsForUnsignedDetailsSection();
   }
   else {
      setDefaultsForPaymentDetailsSection();
   } 
}

function addLinkToSetDefaults() {
    $(".section").prev().each(function (i) {
        var legendText = $(this).text();
        $(this).text("");

        var setDefaultMethod = "setDefaultsFor" + capitalize($(this).next().attr("id")) + "()";

        var newlink = $(document.createElement("a"));
        newlink.attr({
            id:'link-' + i, name:'link' + i, href:'#'
        });
        newlink.append(document.createTextNode(legendText));
        newlink.bind('click', function () {
            eval(setDefaultMethod);
        });

        $(this).append(newlink);
    });

    var newbutton = $(document.createElement("input"));
    newbutton.attr({
        id:'defaultAll', value:'Default All', type:'button', onClick:'setDefaultsForAll()'
    });
    newbutton.bind('click', setDefaultsForAll());

    $("#"+payment_form).append(newbutton);
}

function capitalize(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

function setDefaultsForPaymentDetailsSection() {
    $("input[name='transaction_type']").val("authorization");
    $("input[name='reference_number']").val(new Date().getTime());
    $("input[name='amount']").val("100.00");
    $("input[name='recurring_frequency']").val("monthly");
    $("input[name='recurring_amount']").val("100.00");
    $("input[name='currency']").val("USD");
    $("input[name='payment_method']").val("card");
    $("input[name='bill_to_forename']").val("John");
    $("input[name='bill_to_surname']").val("Doe");
    $("input[name='bill_to_email']").val("null@cybersource.com");
    $("input[name='bill_to_phone']").val("02890888888");
    $("input[name='bill_to_address_line1']").val("1 Card Lane");
    $("input[name='bill_to_address_city']").val("My City");
    $("input[name='bill_to_address_state']").val("CA");
    $("input[name='bill_to_address_country']").val("US");
    $("input[name='bill_to_address_postal_code']").val("94043");

}

function setDefaultsForUnsignedDetailsSection(){
    $("input[name='card_type']").val("001");
    $("input[name='card_number']").val("4111111111111111");
    $("input[name='card_expiry_date']").val("11-2020");
}

function set_gifttype() {
    // one time gift
    if ($('#gifttype').is(':checked')) {
        $('#onetime').show();
        $('#subscription').hide();
    // subscription gift
    } else {
        $('#onetime').hide();
        $('#subscription').show();  
    }
}

function submit_signed() {
    // one time gift
    if ($('#gifttype').is(':checked')) {
        $("input[name='recurring_amount']").val("");
        $("input[name='recurring_frequency']").val("");
        $("input[name='transaction_type']").val("authorization");
    // subscription gift
    } else {
        $("input[name='amount']").val("0");
        $("input[name='transaction_type']").val("authorization,create_payment_token");
    }

    // perform validation

    // finish submit
    return true;
}