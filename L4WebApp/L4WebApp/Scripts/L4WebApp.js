$(function () {
    $('#addForm').validator();
})


$('#contactTable').on('click', 'tbody > tr', function (e) {
    e.preventDefault();
    $(this).toggleClass("info");
})


$("#k-add").on('click', function (e) {
    e.preventDefault();
    var valuesArr = new Array();
    valuesArr[0] = $("#addFirstName").val();
    valuesArr[1] = $("#addLastName").val();
    valuesArr[2] = $("#addTelephone").val();
    valuesArr[3] = $("#addEmail").val();

    var data = { values: valuesArr };

    $.ajax({
        type: "POST",
        url: '/Home/Create',
        data: data,
        dataType: "json",
        traditional: true,
        success: function (result) {
            if (result != false) {
                $("#addForm :input").each(function () {
                    $(this).val('');
                });
                updateContacts();
            }
            $("#addFirstName").focus();
        }
    });
});

$("#k-remove").on('click', function (e) {
    e.preventDefault();
    var activated = new Array()
    $("tr.info").each(function () {
        activated.push($(this).data("attribute"));
    });

    $.ajax({
        type: "POST",
        url: '/Home/Delete',
        data: { ids: activated },
        traditional: true,
        success: function (result) {
            if (result != false) {
                updateContacts();
            }
        }
    });
});

function updateContacts() {
    $.ajax({
        url: "/Home/GetContacts",
        type: "GET",
        success: function (resultView) {
            $("#contactTable").html(resultView);
        }
    });
}