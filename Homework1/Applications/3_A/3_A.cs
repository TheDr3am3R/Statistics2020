
// Form load event or a similar place
private void Form_Load(object sender, EventArgs e)
{
    // Enable drag and drop for this form
    // (this can also be applied to any controls)
    this.AllowDrop = true;
 
    // Add event handlers for the drag & drop functionality
    this.DragEnter += new DragEventHandler(Form_DragEnter);
    this.DragDrop += new DragEventHandler(Form_DragDrop);
}
 
// This event occurs when the user drags over the form with 
// the mouse during a drag drop operation 
void Form_DragEnter(object sender, DragEventArgs e)
{
    // Check if the Dataformat of the data can be accepted
    // (we only accept file drops from Explorer, etc.)
    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy; // Okay
    else
        e.Effect = DragDropEffects.None; // Unknown data, ignore it
 
}
 
// Occurs when the user releases the mouse over the drop target 
void Form_DragDrop(object sender, DragEventArgs e)
{
    // Extract the data from the DataObject-Container into a string list
    string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
 
    // Do something with the data...
 
    // For example add all files into a simple label control:
    foreach (string File in FileList)
        this.label.Text += File + "\n";
}
