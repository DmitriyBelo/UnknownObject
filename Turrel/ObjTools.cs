using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Turrel
{
    public static class ObjTools
    {
        /// <summary>
        /// Add new target in list
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static bool AddNewTarget(GameObject obj , GameObject[] TargetList)
        {
            try
            {
                int index_ = 0;

                foreach (GameObject lObj in TargetList)
                {
                    if (lObj == null)
                    {
                        TargetList[index_] = obj;
                        break;
                    }
                    index_++;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        /// <summary>
        /// Remove target from list
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool RemoveTarget(string name, GameObject[] TargetList)
        {
            try
            {
                int index_ = 0;

                foreach (GameObject lObj in TargetList)
                {
                    if (lObj != null)
                    {
                        if (lObj.obj_name == name)
                        {
                            TargetList[index_] = null;
                            break;
                        }
                    }
                    index_++;
                }
                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        /// <summary>
        /// Get next object in list or empty 
        /// </summary>
        public static string  GetNextObj(string prev_obj, GameObject[] TargetList)
        {
            try
            {
                string objName = "";
                int index_ = 0;

                if (!String.IsNullOrEmpty(prev_obj))
                {
                    foreach (GameObject fObj in TargetList)
                    {
                        if (fObj != null)
                        {
                            if (fObj.obj_name == prev_obj)
                            {

                                for (int k = index_+1; k < TargetList.Length; k++)
                                {
                                    if (TargetList[k] != null)
                                    {
                                        objName = TargetList[k].obj_name;
                                        MessageBox.Show("Next obj name is : " + objName);
                                        break;
                                    }
                                }
                            }

                        }
                        index_++;
                    }
                }
                return objName;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
                return "";
            }
        }

        /// <summary>
        /// Sort objects list 
        /// </summary>
        /// <param name="TargetList"></param>
        public static void SortObjs (GameObject[] TargetList)
        {

            List<GameObject> TempObjList = new List<GameObject>(); 

            try
            {
                for(int k = 0; k<TargetList.Length; k++)
                {
                    if(TargetList[k] != null)
                    {
                        TempObjList.Add(TargetList[k]);
                        TargetList[k] = null;
                    }
                }

               for (int k = 0; k < TempObjList.Count; k++)
                {
                    TargetList[k] = TempObjList[k];
                }

                TempObjList.Clear();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
