using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.Xaml.Interactivity;

namespace Diablo3Hub.Behaviors
{
    /// <summary>
    /// ListView, GridView의 SelectedItems 프로퍼티의 데이터와 바인딩 할 수 있는 비헤이비어
    /// </summary>
    public class SelectedItemsBehavior : DependencyObject, IBehavior
    {
        /// <summary>
        ///     비헤이비어에 붙어있는 프로퍼티
        /// </summary>
        public static readonly DependencyProperty SelectedItemsProperty =
            DependencyProperty.Register("SelectedItems", typeof(object), typeof(SelectedItemsBehavior),
                new PropertyMetadata(null, OnSelectedItemsChanged));

        /// <summary>
        ///     _isWork
        /// </summary>
        private bool _isWork;

        /// <summary>
        ///     뷰 모델의 프로퍼티 - 반드시 object로 만든다. 다른형은 프로퍼티 추가가 않된다.
        /// </summary>
        public object SelectedItems
        {
            get => GetValue(SelectedItemsProperty);
            set => SetValue(SelectedItemsProperty, value);
        }

        /// <summary>
        ///     연결되어있는 오브젝트
        /// </summary>
        public DependencyObject AssociatedObject { get; private set; }

        /// <summary>
        ///     Listview에 연결 될때 실행되는 메소드
        /// </summary>
        /// <param name="associatedObject"></param>
        public void Attach(DependencyObject associatedObject)
        {
            if (associatedObject == AssociatedObject || DesignMode.DesignModeEnabled) return;
            if (AssociatedObject != null)
                throw new InvalidOperationException("Cannot attach behavior multiple times.");

            AssociatedObject = associatedObject;
            var control = AssociatedObject as ListViewBase;
            if (control == null)
                throw new InvalidOperationException("Cannot attach behavior you must have ListViewBase.");
            //SelectedItems가 Runtime Object임
            control.SelectionChanged += control_SelectionChanged;
        }

        /// <summary>
        ///     ListView 연결 해제될때 실행되는 메소드
        /// </summary>
        public void Detach()
        {
            if (SelectedItems != null)
                ((INotifyCollectionChanged) SelectedItems).CollectionChanged -= ViewModelToControl_CollectionChanged;

            if (AssociatedObject != null)
                ((ListViewBase) AssociatedObject).SelectionChanged -= control_SelectionChanged;
            AssociatedObject = null;
        }

        /// <summary>
        ///     컨트롤에 변경 사항을 뷰모델로 반영
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void control_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lock (this)
            {
                if (_isWork) return;
                _isWork = true;
            }

            var control = AssociatedObject as ListViewBase;
            if (control == null) return;

            var list = SelectedItems as IList;
            if (list == null) return;

            if (e.AddedItems != null && e.AddedItems.Any())
                foreach (var addedItem in e.AddedItems)
                {
                    var existIndex = list.IndexOf(addedItem);
                    if (existIndex == -1)
                        list.Add(addedItem);
                }
            if (e.RemovedItems != null && e.RemovedItems.Any())
                foreach (var removedItem in e.RemovedItems)
                {
                    var existIndex = list.IndexOf(removedItem);
                    if (existIndex > -1)
                        list.Remove(removedItem);
                }
            _isWork = false;
        }

        /// <summary>
        ///     비헤이비어 프로퍼티 체인지 이벤트
        /// </summary>
        private static void OnSelectedItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var source = (SelectedItemsBehavior) d;
            //이전 프로퍼티에 붙어있던 이벤트 제거
            var oldCollection = e.OldValue as INotifyCollectionChanged;
            if (oldCollection != null)
                oldCollection.CollectionChanged -= source.ViewModelToControl_CollectionChanged;
            //새 프로퍼티에 이벤트 연결
            var newCollection = e.NewValue as INotifyCollectionChanged;
            if (newCollection != null)
                newCollection.CollectionChanged += source.ViewModelToControl_CollectionChanged;
        }

        /// <summary>
        ///     뷰모델의 프로퍼티에서 발생한 이벤트를 이용해서 컨트롤에 작업
        /// </summary>
        private void ViewModelToControl_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            lock (this)
            {
                if (_isWork) return;
                _isWork = true;
            }

            var control = AssociatedObject as ListViewBase;

            //Reset처리
            if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                if (control == null) return;
                control.SelectedItems.Clear();
            }

            //삭제된 아이템 처리
            if (e.OldItems != null)
                foreach (var item in e.OldItems)
                    if (control != null && control.SelectedItems.Contains(item))
                        control.SelectedItems.Remove(item);
            //추가된 아이템 처리
            if (e.NewItems != null)
                try
                {
                    foreach (var item in e.NewItems)
                        if (control != null && control.SelectedItems.Contains(item) == false)
                            control.SelectedItems.Add(item);
                }
                catch (OutOfMemoryException ome)
                {
                    Debug.Assert(false, ome.Message);
                }
                catch (Exception ex)
                {
                    Debug.Assert(false, ex.Message);
                }
            _isWork = false;
        }

        public void Dispose()
        {
            

        }
    }
}