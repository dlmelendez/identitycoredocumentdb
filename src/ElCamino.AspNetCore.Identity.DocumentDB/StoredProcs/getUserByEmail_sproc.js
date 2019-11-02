﻿// MIT License Copyright 2019 (c) David Melendez. All rights reserved. See License.txt in the project root for license information.

/// <reference group="Generic" /> 
/// <reference path="C:\Program Files (x86)\Microsoft Visual Studio 12.0\JavaScript\References\DocDbWrapperScript.js" /> 
/// http://dl.windowsazure.com/documentDB/jsserverdocs/
function getUserByEmail_v1(normalizedEmail) {
    var collection = getContext().getCollection();
    var emailQuery = 'SELECT * FROM root r WHERE r.normalizedEmail = "' + normalizedEmail + '"';
    //Get the Userid by email
    var isEmailAccepted = collection.queryDocuments(
        collection.getSelfLink(),
        emailQuery,
        function (err, feed, options) {
            if (err) throw err;
            getContext().getResponse().setBody(feed);
        });

}