var dataTable;
let controllerName = "/Customer";
$(document).ready(function () {
    loadDataTableCustomer();
});

function loadDataTableCustomer() {
    dataTable = $('#tblDataCustomer').DataTable({
        "ajax": {
            "url": controllerName+"/GetAll", "dataSrc": ""
        },
        "order": [[0, 'desc']],
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "nameAr", "width": "45%" },
            { "data": "nameEn", "width": "45%" },
        ],
        "bDestroy": true
    });
}
// this is the id of the form
$("#frmCreateCsutomer").submit(function (e) {

    e.preventDefault(); // avoid to execute the actual submit of the form.

    var form = $(this);
    let actionUrls = controllerName+"/Create";
    //var actionUrl = form.attr('action');

    $.ajax({
        type: "POST",
        url: actionUrls,
        data: form.serialize(), // serializes the form's elements.
        success: function (data) {
            if (data.isSuccess) {
                document.getElementById('customerId').value = data.id;
                showSuccessMessage();
                loadDataTable();
            } else {
                showErrorMessage();
            }
        }
    });

});

function openPage(pageName, elmnt, color) {
    var i, tabcontent, tablinks;
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }
    tablinks = document.getElementsByClassName("tablink");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].style.backgroundColor = "";
    }
    document.getElementById(pageName).style.display = "block";
    elmnt.style.backgroundColor = color;
}

// Get the element with id="defaultOpen" and click on it
document.getElementById("defaultOpen").click();