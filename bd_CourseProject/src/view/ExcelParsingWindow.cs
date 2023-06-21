using bd_CourseProject.src.model;
using ExcelDataReader;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace bd_CourseProject.src.view
{
    public partial class ExcelParsingWindow : MaterialForm
    {
        public DataTable dt = new DataTable();
        DataTableCollection tableCollection;
        string tableName;
        int startRow;
        int endRow;

        public ExcelParsingWindow()
        {
            InitializeComponent();

            // Создание столбца с нумерацией строк
            DataGridViewTextBoxColumn rowNumberColumn = new DataGridViewTextBoxColumn();
            rowNumberColumn.HeaderText = "№";
            rowNumberColumn.Name = "RowNumberColumn";
            rowNumberColumn.Width = 30;
            rowNumberColumn.ReadOnly = true;
            rowNumberColumn.Resizable = DataGridViewTriState.False;
            dataGridView.Columns.Insert(0, rowNumberColumn);

            labelUrl.Text = Rosstat.URL_ROSSTAT;
            labelUrlFind.Text = Rosstat.URL_FIND;
            labelPrefix.Text = Rosstat.PREFIX_FIND;
        }

        private void ToolStripOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel Files|*.xls;*.xlsx|CSV files (*.csv)|*.csv",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = false },
                            });
                            tableCollection = result.Tables;

                            cbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cbSheet.Items.Add(table.TableName);
                            }
                            cbSheet.SelectedIndex = 0;
                            panelImportDb.Enabled = true;
                        }
                    }
                }
            }
        }

        private void ToolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripBdConnect_Click(object sender, EventArgs e)
        {
            ConnectionDBWindow dbWindow = new ConnectionDBWindow();
            dbWindow.ShowDialog();
        }

        private void ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.ForeColor = Color.Black; // Устанавливаем новый цвет шрифта
        }

        private void ToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.ForeColor = Color.White; // Восстанавливаем исходный цвет шрифта
        }

        private void CbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = EditDataTable(tableCollection[cbSheet.SelectedItem.ToString()]);
                
                endRow = dt.Rows.Count;
                numericDown.Maximum = endRow;
                numericDown.Value = endRow;

                DataSourceBinding();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            // Создание экземпляра FolderBrowserDialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Установка свойств и текста для диалогового окна
                folderBrowserDialog.Description = "Выберите папку для сохранения файлов";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;

                // Отображение диалогового окна и обработка результата
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    
                    // Создание экземпляра Progress<T> для обновления ProgressBar
                    Progress<int> progress = new Progress<int>(value =>
                    {
                        progressBar.Value = value;
                        if (value == 100)
                        {
                            MessageBox.Show("Файлы успешно загружены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    });

                    // Выполнение действий для сохранения файлов в выбранной папке с передачей прогресса
                    await DataFiles.DownloadFilesAsync(selectedPath, progress);

                    // Удаление ProgressBar с формы
                    Controls.Remove(progressBar);
                }
            }
        }

        private void NumericUpDown_Changed(object sender, EventArgs e)
        {
            startRow = (int)numericUp.Value;
            endRow = (int)numericDown.Value;
            DataSourceBinding();
        }

        private async void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbTablename.Text))
                {
                    tableName = tbTablename.Text;
                    await MSSQLQuery.CreateParsedTableAsync(tableName);
                    MSSQLQuery.InsertDataIntoParsedTable(averageSalaryBindingSource.DataSource as List<AverageSalary>, tableName);
                    if (!await MSSQLQuery.ExistenceСheckDirectoryTableAsync())
                    {
                        await MSSQLQuery.CreateDirectoryTableAsync(tableName);
                    }
                    await MSSQLQuery.InsertDataIntoDirectoryTableAsync(tableName);

                    MessageBox.Show("Импорт данных в БД успешно произведен!");
                }
                else
                    MessageBox.Show("Введите наименование создаваемой таблицы!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataSourceBinding()
        {
            if (dt != null)
            {
                List<AverageSalary> averageSalaries = new List<AverageSalary>();
                for (int i = startRow; i < endRow; i++)
                {
                    AverageSalary obj = new AverageSalary
                    {
                        territory = dt.Rows[i]["Column0"].ToString(),
                        ped_work_edu_preschool = dt.Rows[i]["Column1"].ToString(),
                        ped_work_edu_gnrl = dt.Rows[i]["Column2"].ToString(),
                        ped_work_edu_addchldrn = dt.Rows[i]["Column3"].ToString(),
                        tchrs_edu_organprim_secondvoc = dt.Rows[i]["Column4"].ToString(),
                        tchrs_edu_higherprof = dt.Rows[i]["Column5"].ToString(),
                        dctrs_highermed_edu_medsrvcs = dt.Rows[i]["Column6"].ToString(),
                        par_med_prs_medsrvcs = dt.Rows[i]["Column7"].ToString(),
                        junior_dctrs_medsrvcs = dt.Rows[i]["Column8"].ToString(),
                        social_work = dt.Rows[i]["Column9"].ToString(),
                        work_cultural_institutions = dt.Rows[i]["Column10"].ToString(),
                        scientific_staff = dt.Rows[i]["Column11"].ToString(),
                        ped_work_edu_med_sclsrvcs = dt.Rows[i]["Column12"].ToString()
                    };
                    averageSalaries.Add(obj);
                }
                averageSalaryBindingSource.DataSource = averageSalaries;
            }
        }

        private DataTable EditDataTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    string cellValue = row[j].ToString();

                    // Заменяем значения "…1)" и "-" на "0"
                    if (cellValue == "…1)" || cellValue == "-")
                    {
                        row[j] = "0";
                    }
                }
            }

            // Удаляем строки, в которых значение столбца "Column0" равно "в том числе:"
            DataRow[] rowsToDelete = dataTable.Select("Column0 = 'в том числе:'");
            foreach (DataRow rowToDelete in rowsToDelete)
            {
                rowToDelete.Delete();
            }

            dataTable.AcceptChanges();
            return dataTable;
        }

        private void dataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Cells["RowNumberColumn"].Value = (i + 1).ToString();
            }
        }
    }
}
