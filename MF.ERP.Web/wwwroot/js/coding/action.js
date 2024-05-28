var dataTable;
let controllerName = "/Actions";
$(document).ready(function () {
    loadDataTable();
});




$(document).on('click', ".btnCreate", function () {
    clear();
    drawModel("CreateNew");
});
function clear() {
    $('#sId').val(0);
    //$('#nameInput').val('');
    //$('#nameEnInput').val('');
}

$(document).on('click', ".btnEdit", function () {
    clear();
    let sid = $(this).attr('sid');
    getEntityById(controllerName, sid, fillData, showErrorMessage)

});
$(document).on('click', ".btnDelete", function () {
    clear();
    let sid = $(this).attr('sid');
    deleteById(controllerName, sid, deleteEntity, showErrorMessage)

});
function fillData(entity) {
    $('#sId').val(entity.id);

    drawModel("Edit");
}

function deleteEntity(data) {
    if (data.isSuccess) {
        showSuccessMessage();
        loadDataTable();
    }
}

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": controllerName+"/GetAll", "dataSrc": ""
        },
        "order": [[0, 'desc']],
        "columns": [
            { "data": "id", "width": "10%" },
            { "data": "representiveName", "width": "25%" },
            { "data": "startDate", "width": "25%" },
            { "data": "notes", "width": "40%" },
            {
                title: "", "width": "10%",
                render: function (data, type, full) {
                    return `  
  <a class="btn btn-outline-primary btn-sm btnEdit" sid='${full.id}' data-toggle="modal" > <i class="fa fa-edit"></i> </a>
  <a class="btn btn-outline-danger btn-sm btnDelete" sid='${full.id}' data-toggle="modal" ><i class="fa-solid fa-trash  "></i></a> 
                        `
                },
            },
        ],
        "bDestroy": true
    });
}
$("#frmCreate").submit(function (e) {
    e.preventDefault(); // Prevent the actual form submission

    var form = $(this);
    var actionUrls = controllerName + "/Create"; // Replace with your controller action URL
    var list = [];

    // Collect details from the table
    $('#ExpTable').find("tr:gt(0)").each(function () {
        var result = {
            Id: $(this).find("td:eq(0)").text(),
            ProductId: $(this).find("td:eq(1)").text(),
            Qty: parseFloat($(this).find("td:eq(2)").text()),
            Price: parseFloat($(this).find("td:eq(3)").text()),
            Total: parseFloat($(this).find("td:eq(4)").text())
        };
        list.push(result);
    });

    // Create a FormData object
    var formData = new FormData();

    // Append master fields to the FormData object
    form.serializeArray().forEach(function (field) {
        formData.append(field.name, field.value);
    });

    // Append each item in the details list to the FormData object
    list.forEach(function (item, index) {
        formData.append(`Details[${index}].Id`, item.Id);
        formData.append(`Details[${index}].ProductId`, item.ProductId);
        formData.append(`Details[${index}].Qty`, item.Qty);
        formData.append(`Details[${index}].Price`, item.Price);
        formData.append(`Details[${index}].Total`, item.Total);
    });

    // Perform the AJAX request
    $.ajax({
        type: "POST",
        url: actionUrls,
        data: formData, // Use FormData object for the data
        processData: false, // Tell jQuery not to process the data
        contentType: false, // Tell jQuery not to set contentType
        success: function (data) {
            if (data.isSuccess) {
                showSuccessMessage(); // Your success message function
                loadDataTable(); // Function to reload your data table
            } else {
                showErrorMessage(); // Your error message function
            }
        },
        error: function (xhr, status, error) {
            console.error(error); // Log any errors
        }
    });
});
function drawModel(mTitle, mData, callBack = null) {

    if (mTitle === 'CreateNew') {
        $('#ModalTitleCreate').removeClass('d-none');
        $('#ModalTitleEdit').addClass('d-none');
    }
    else {
        $('#ModalTitleCreate').addClass('d-none');
        $('#ModalTitleEdit').removeClass('d-none');
    }
    $('#exampleModalLongTitle').text(mTitle);

    $('#results').html(mData);

    $('#exampleModalCenter').modal('show');
    if (callBack != null) {
        callBack();
    }
}
function hideModel() {

    $('#exampleModalCenter').modal('hide');
}


function AddItem(btn) {
    //debugger;
    if ($('#customerId').val() == 0 || $('#customerId').val() == "") {
       
      
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'برجاء تحديد العميل',
            customClass: {
                confirmButton: "btn btn-primary"
            }
        });
        return false;

    }
    if ($('#actionId').val() == 0 || $('#actionId').val() == "") {

        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'برجاء تحديد الاجراء',
            customClass: {
                confirmButton: "btn btn-primary"
            }
        });
        return false;
    }
    if ($('#nextActionId').val() == 0 || $('#nextActionId').val() == "") {

        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'برجاء تحديد الاجراء القادم',
            customClass: {
                confirmButton: "btn btn-primary"
            }
        });
        return false;
    }


    var button = '<button id="Remove" type="button" class="btn btn-sm btn-danger visible" onclick="DeleteItem(this)">Remove</button>';
    $('#ExpTable tbody').append("<tr><td hidden></td><td hidden>" + $('#customerId').val() + "</td><td>" + $('#customerId option:selected').text() + "</td><td hidden>" + $('#actionId').val() + "</td><td>" + $('#actionId option:selected').text() + "</td><td>" + $('#actionDateDetails').val() + "</td><td hidden>" + $('#nextActionId').val() + "</td><td>" + $('#nextActionId option:selected').text() + "</td><td>" + $('#nextActionDate').val() + "</td><td>" + $('#result').val() + "</td><td>" + button + "</td></tr>");

}
