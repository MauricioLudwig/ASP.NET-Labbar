$(document).ready(function () {
    $('.customer-box').hover(function () {

        //var id = $(this).attr("customer-id");
        //var city = $(this).attr("customer-city");
        //var name = $(this).attr("customer-name");
        //$('#customer-info').html('Id: ' + id + ', Name: ' + name + ', City: ' + city);

        // doPartialPageUpdate($(this).attr('customer-id'));

        $.ajax({
            url: "/Home/AuthorBox/" + $(this).attr('customer-id'),
            type: "GET",
            success: function (html) {
                $('#showAllCustomers').html(html);
            }
        });

        console.log('Mouse enter');
    }, function () {
        $('#customer-info').empty();
        console.log("Mouse leave");
        });

    $('#showAllBtn').click(function () {
        $.get("/Shared/CustomerBox", function (data) {

        });
    });

});

function doPartialPageUpdate(customerId) {
    $.get("/Home/AuthorBox",
        {
            "id": customerId
        },
        function (data) {
            $("#customer-info").html(data);
            console.log('inside doPartialPageUpdate function');
        }
    );
}