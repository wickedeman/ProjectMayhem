// Import Folder as SpriteSheet - Photoshop CS/CS2 Script
// Description: Imports a series of images (from the designated folder) in SpriteSheet
// Version: 1.0.0, 10/April/2007
// Version: 1.0.1, 10/April/2007 - Compatibilização com CS2 9.0.2
// Version: 1.0.0, 10/April/2007 - Agora pode ter qualquer tipo de arquivo na pasta, 
//                                 porém serão aberto somente imagens nos seguintes formatos
//                                 (gif, jpg, png, tif, psd)

// Author: Ney Estrabelli
// Thanks Trevor Morris for Import Folder as Layer Script
// Thanks Mark McCoy for SpriteSheet generator		
// Website: http://www.neyestrabelli.com
// ============================================================================
// Installation:
// 1. Place script in 'C:\Program Files\Adobe\Adobe Photoshop CS2\Presets\Scripts\'
// 2. Restart Photoshop
// 3. Choose File > Scripts > ImportFolderAsSpriteSheet
// ============================================================================


function getCSVersion() {
	return parseInt(version);
}

///////////////////////////////////////////////////////////////////////////////
// getFolder - prompt for source folder
///////////////////////////////////////////////////////////////////////////////
function getFolder() {
	//alert("Antes de Iniciar, verifique se as imagens possuem o mesmo tamanho");
	var defaultOpenFolder = '~'; // default browse location/folder (default: '~')

	// display the Path Entry dialog with Browse option for Photoshop CS
	if (getCSVersion() === 8) {
		// create dialog for pasting/typing path to images folder
		var dlg = new Window('dialog', 'Import Folders as SpriteSheet', [0,0,480,118]);
		dlg.center();
		dlg.add('statictext', [15,15,460,35], 'Selecione a Pasta Com as Imagens:');
		dlg.add('edittext', [15,45,465,65], '', {name: 'pathText'});
		dlg.pathText.active = true;
		dlg.add('button', [235,80,305,103], 'Browse', {name: 'browse'});
		dlg.browse.onClick = function() {this.parent.close(3);};
		dlg.add('button', [315,80,385,103], 'OK', {name: 'ok'});
		dlg.add('button', [395,80,465,103], 'Cancel', {name: 'cancel'});
		dlg.result = dlg.show(); // display dialog

		if (dlg.result == 3) { // Browse
			return Folder.selectDialog('Selecione a Pasta Com as Imagens:', Folder(defaultOpenFolder));
		}
		else if (dlg.result == 1) { // OK
			return Folder(dlg.pathText.text);
		}
		else { // Cancel (dlg.result == 0)
			return null;
		}
	}
	// display only the browse dialog for Photoshop CS2+
	else {
		return Folder.selectDialog('Selecione a Pasta Com as Imagens:', Folder(defaultOpenFolder));
	}
}

///////////////////////////////////////////////////////////////////////////////
// importFolderAsSpriteSheet - main function
///////////////////////////////////////////////////////////////////////////////
function importFolderAsSpriteSheet(selectedFolder) {
	// user-customizable variables
	var savePrompt = false; // display save prompt upon completion (default: false)

	// if a folder was selected continue with action; otherwise quit
	if (selectedFolder) {

		// create document list from files in selected folder
		var docList = selectedFolder.getFiles();
		for (var i = 0; i < docList.length; i++) {

			// open each document in file list
			if (docList[i] instanceof File) {
				// get the file name
				var fName = docList[i].name.toLowerCase();

				// check for supported file formats
				if ((fName.indexOf('.gif') == -1) && (fName.indexOf('.jpg') == -1) && (fName.indexOf('.png') == -1) && (fName.indexOf('.bmp') == -1) && (fName.indexOf('.tif') == -1) && (fName.indexOf('.psd') == -1)) {
					// skip unsupported formats
				}
				else {
					// if supported documents exist, create a new document
					if (!newCanvas) {
						open(docList[i]); // open documents from list
						var file = activeDocument;
						var width = file.width;
						var height = file.height;
						file.close();
						// remember unit settings and change to pixels
						var originalRulerUnits = preferences.rulerUnits;
						preferences.rulerUnits = Units.PIXELS;
						var newDocName = 'SpriteSheet' + (documents.length ? ' ' + documents.length : '');
						var newDoc = documents.add(width,height , 72, newDocName, NewDocumentMode.RGB, DocumentFill.TRANSPARENT, 1);

						// restore original unit setting
						preferences.rulerUnits = originalRulerUnits;
						var newCanvas = true;
					}

					// combine documents into new document using their original names
					open(docList[i]); // open documents from list

					var docRef = activeDocument;
					var docName = docRef.name; // get document name
					//docRef.flatten();
					docRef.changeMode(ChangeMode.RGB);

					// duplicate the layer into the new document
					docRef.activeLayer.duplicate(documents[newDoc.name], ElementPlacement.PLACEATBEGINNING);
					docRef.close(SaveOptions.DONOTSAVECHANGES);

					// name duplicate layer using the original document name (without the extension)
					newDoc.activeLayer.name = docName.substring(0, docName.lastIndexOf('.'));
				}
			}
		}
	
		// delete empty layer; then reveal and trim canvas to fit all layers
		if (newCanvas) {
			newDoc.artLayers[newDoc.layers.length - 1].remove();
			newDoc.revealAll();
			//newDoc.trim(TrimType.TRANSPARENT, true, true, true, true);

			// save the final document (prompt)
			if (savePrompt) {
				var saveDoc = File.saveDialog('Salvar Como:');
				if (saveDoc) {
					activeDocument.saveAs(saveDoc);
				}
			}
		}
		else {
			// display error message if no supported documents were found in the designated folder
			alert('Desculpe, a pasta selecionada não contém imagens suportadas');
			importFolderAsSpriteSheet(getFolder());
		}
	}
	else {
		// alert('The action has been cancelled.');
	}
	if (documents.length > 0)
    {
	var cols = prompt("Informe o número de colunas",app.activeDocument.layers.length,cols);
       
        // --------------------------
        docRef = activeDocument;   
        var activeLayer = docRef.activeLayer;

        numLayers = docRef.artLayers.length;    
       
        var rows = Math.ceil(numLayers/cols);
       
         var spriteX = docRef.width;
         var spriteY = docRef.height;   
       
        // put things in order
        app.preferences.rulerUnits = Units.PIXELS;
       
        // resize the canvas
         newX = spriteX * cols;
         newY = spriteY * rows;
        
         docRef.resizeCanvas( newX, newY, AnchorPosition.TOPLEFT );
             
        // move the layers around
         var rowi = 0;
         var coli = 0;
        
         for (i=(numLayers - 1); i >= 0; i--)
         {    
             docRef.artLayers[i].visible = 1;
            
              var movX = spriteX*coli;
              var movY = spriteY*rowi;
             
             docRef.artLayers[i].translate(movX, movY);
            
             coli++;
             if (coli > (cols - 1))
             {
                 rowi++;
                 coli = 0;
             }
         }
         docRef.mergeVisibleLayers();        
    }

}

// call the main function
importFolderAsSpriteSheet(getFolder());
