/**
 * Created by Allan on 1/27/2015.
 */

function ViewModule() { };

ViewModule.Title = "Leopard Data Minimal Home";

ViewModule.minimal = null;

// page vars

// page controls

ViewModule.paragraph = $('#data');

ViewModule.Initialize = function(minimal) {
    var self = this;

    self.minimal = minimal;

    // load page control references

    // initialize initial control state

    // load up events

    var objectToSend = {};

    postAjaj("api/HelloWorld", objectToSend, function (data) {
        ViewModule.paragraph.text(data);
    });
};

ViewModule.Deinitialize = function() {
    var self = this;
};




