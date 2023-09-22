// ----------------------------------------------------------------------------
// File: custom.js
// Author: Andrew Hatton
// Date: September 30, 2023
// Description: JavaScript interop functions for Blazor app.
// ----------------------------------------------------------------------------

window.downloadFile = function (fileName, filePath) {
    const anchor = document.createElement('a');
    anchor.href = filePath;
    anchor.download = fileName;
    anchor.style.display = 'none';
    document.body.appendChild(anchor);
    anchor.click();
    document.body.removeChild(anchor);
};
