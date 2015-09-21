$("#contactTable > tbody > tr").click(function (e) {
    e.preventDefault();
    $(this).toggleClass("info");
});