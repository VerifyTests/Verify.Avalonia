namespace VerifyTests;

public static partial class VerifyAvalonia
{
    static void AddConverters() =>
        VerifierSettings.AddExtraSettings(
            _ =>
            {
                _.Converters.Add(new CheckBoxConverter());
                _.Converters.Add(new ContextMenuConverter());
                _.Converters.Add(new MenuFlyoutPresenterConverter());
                _.Converters.Add(new MenuConverter());
                _.Converters.Add(new MenuItemConverter());
                _.Converters.Add(new RadioButtonConverter());
                _.Converters.Add(new ToggleSwitchConverter());
                _.Converters.Add(new WindowConverter());
                _.Converters.Add(new PopupRootConverter());
                _.Converters.Add(new ButtonSpinnerConverter());
                _.Converters.Add(new CarouselConverter());
                _.Converters.Add(new ComboBoxConverter());
                _.Converters.Add(new ComboBoxItemConverter());
                _.Converters.Add(new DropDownButtonConverter());
                _.Converters.Add(new ExpanderConverter());
                _.Converters.Add(new ListBoxConverter());
                _.Converters.Add(new MenuBaseConverter());
                _.Converters.Add(new RepeatButtonConverter());
                _.Converters.Add(new ToggleSplitButtonConverter());
                _.Converters.Add(new TabControlConverter());
                _.Converters.Add(new TabItemConverter());
                _.Converters.Add(new TreeViewItemConverter());
                _.Converters.Add(new WindowBaseConverter());
                _.Converters.Add(new EmbeddableControlRootConverter());
                _.Converters.Add(new CalendarButtonConverter());
                _.Converters.Add(new CalendarDayButtonConverter());
                _.Converters.Add(new HeaderedSelectingItemsControlConverter());
                _.Converters.Add(new TabStripConverter());
                _.Converters.Add(new TabStripItemConverter());
                _.Converters.Add(new ToggleButtonConverter());
                _.Converters.Add(new ColorSliderConverter());
                _.Converters.Add(new ButtonConverter());
                _.Converters.Add(new DataValidationErrorsConverter());
                _.Converters.Add(new DatePickerPresenterConverter());
                _.Converters.Add(new TimePickerPresenterConverter());
                _.Converters.Add(new FlyoutPresenterConverter());
                _.Converters.Add(new GridSplitterConverter());
                _.Converters.Add(new LabelConverter());
                _.Converters.Add(new ListBoxItemConverter());
                _.Converters.Add(new MaskedTextBoxConverter());
                _.Converters.Add(new ReversibleStackPanelConverter());
                _.Converters.Add(new PathIconConverter());
                _.Converters.Add(new ProgressBarConverter());
                _.Converters.Add(new RefreshContainerConverter());
                _.Converters.Add(new RefreshVisualizerConverter());
                _.Converters.Add(new ScrollViewerConverter());
                _.Converters.Add(new SliderConverter());
                _.Converters.Add(new SpinnerConverter());
                _.Converters.Add(new SplitButtonConverter());
                _.Converters.Add(new SplitViewConverter());
                _.Converters.Add(new ToolTipConverter());
                _.Converters.Add(new TopLevelConverter());
                _.Converters.Add(new TransitioningContentControlConverter());
                _.Converters.Add(new TreeViewConverter());
                _.Converters.Add(new UserControlConverter());
                _.Converters.Add(new VirtualizingCarouselPanelConverter());
                _.Converters.Add(new VirtualizingStackPanelConverter());
                _.Converters.Add(new NotificationCardConverter());
                _.Converters.Add(new AdornerLayerConverter());
                _.Converters.Add(new HeaderedContentControlConverter());
                _.Converters.Add(new HeaderedItemsControlConverter());
                _.Converters.Add(new LightDismissOverlayLayerConverter());
                _.Converters.Add(new OverlayLayerConverter());
                _.Converters.Add(new OverlayPopupHostConverter());
                _.Converters.Add(new ScrollBarConverter());
                _.Converters.Add(new SelectingItemsControlConverter());
                _.Converters.Add(new ColorPickerConverter());
                _.Converters.Add(new DataGridCellConverter());
                _.Converters.Add(new DataGridColumnHeaderConverter());
                _.Converters.Add(new DataGridRowHeaderConverter());
                _.Converters.Add(new DataGridFrozenGridConverter());
                _.Converters.Add(new AutoCompleteBoxConverter());
                _.Converters.Add(new BorderConverter());
                _.Converters.Add(new CalendarDatePickerConverter());
                _.Converters.Add(new CalendarConverter());
                _.Converters.Add(new CanvasConverter());
                _.Converters.Add(new ContentControlConverter());
                _.Converters.Add(new DatePickerConverter());
                _.Converters.Add(new TimePickerConverter());
                _.Converters.Add(new DockPanelConverter());
                _.Converters.Add(new ExperimentalAcrylicBorderConverter());
                _.Converters.Add(new GridConverter());
                _.Converters.Add(new IconElementConverter());
                _.Converters.Add(new ItemsControlConverter());
                _.Converters.Add(new LayoutTransformControlConverter());
                _.Converters.Add(new NativeMenuBarConverter());
                _.Converters.Add(new NumericUpDownConverter());
                _.Converters.Add(new RelativePanelConverter());
                _.Converters.Add(new SelectableTextBlockConverter());
                _.Converters.Add(new SeparatorConverter());
                _.Converters.Add(new StackPanelConverter());
                _.Converters.Add(new TextBoxConverter());
                _.Converters.Add(new ThemeVariantScopeConverter());
                _.Converters.Add(new VirtualizingPanelConverter());
                _.Converters.Add(new WrapPanelConverter());
                _.Converters.Add(new ArcConverter());
                _.Converters.Add(new EllipseConverter());
                _.Converters.Add(new LineConverter());
                _.Converters.Add(new PathConverter());
                _.Converters.Add(new PolygonConverter());
                _.Converters.Add(new PolylineConverter());
                _.Converters.Add(new RectangleConverter());
                _.Converters.Add(new SectorConverter());
                _.Converters.Add(new ScrollContentPresenterConverter());
                _.Converters.Add(new WindowNotificationManagerConverter());
                _.Converters.Add(new CaptionButtonsConverter());
                _.Converters.Add(new TitleBarConverter());
                _.Converters.Add(new CalendarItemConverter());
                _.Converters.Add(new DateTimePickerPanelConverter());
                _.Converters.Add(new PickerPresenterBaseConverter());
                _.Converters.Add(new AccessTextConverter());
                _.Converters.Add(new ChromeOverlayLayerConverter());
                _.Converters.Add(new RangeBaseConverter());
                _.Converters.Add(new ThumbConverter());
                _.Converters.Add(new UniformGridConverter());
                _.Converters.Add(new VisualLayerManagerConverter());
                _.Converters.Add(new ColorViewConverter());
                _.Converters.Add(new ColorPreviewerConverter());
                _.Converters.Add(new ColorSpectrumConverter());
                _.Converters.Add(new DataGridConverter());
                _.Converters.Add(new DataGridRowConverter());
                _.Converters.Add(new DataGridRowGroupHeaderConverter());
                _.Converters.Add(new DataGridCellsPresenterConverter());
                _.Converters.Add(new DataGridColumnHeadersPresenterConverter());
                _.Converters.Add(new DataGridDetailsPresenterConverter());
                _.Converters.Add(new DataGridRowsPresenterConverter());
                _.Converters.Add(new DecoratorConverter());
                _.Converters.Add(new ImageConverter());
                _.Converters.Add(new NativeControlHostConverter());
                _.Converters.Add(new PanelConverter());
                _.Converters.Add(new TextBlockConverter());
                _.Converters.Add(new TickBarConverter());
                _.Converters.Add(new ViewboxConverter());
                _.Converters.Add(new ShapeConverter());
                _.Converters.Add(new RemoteWidgetConverter());
                _.Converters.Add(new ContentPresenterConverter());
                _.Converters.Add(new ItemsPresenterConverter());
                _.Converters.Add(new TextPresenterConverter());
                _.Converters.Add(new PopupConverter());
                _.Converters.Add(new TemplatedControlConverter());
                _.Converters.Add(new TrackConverter());
                _.Converters.Add(new ControlConverter());
                _.Converters.Add(new InputElementConverter());
                _.Converters.Add(new InteractiveConverter());
                _.Converters.Add(new LayoutableConverter());
                _.Converters.Add(new VisualConverter());
             });
         internal static bool IsMemberValueInherited(Visual visual, string member, object? value)
         {
             var parent = visual.Parent;
             if (parent == null)
             {
                 return false;
             }
             if (parent is CheckBox checkBox)
             {
                 return CheckBoxConverter.MemberHasValue(checkBox, member, value);
             }
             if (parent is ContextMenu contextMenu)
             {
                 return ContextMenuConverter.MemberHasValue(contextMenu, member, value);
             }
             if (parent is MenuFlyoutPresenter menuFlyoutPresenter)
             {
                 return MenuFlyoutPresenterConverter.MemberHasValue(menuFlyoutPresenter, member, value);
             }
             if (parent is Menu menu)
             {
                 return MenuConverter.MemberHasValue(menu, member, value);
             }
             if (parent is MenuItem menuItem)
             {
                 return MenuItemConverter.MemberHasValue(menuItem, member, value);
             }
             if (parent is RadioButton radioButton)
             {
                 return RadioButtonConverter.MemberHasValue(radioButton, member, value);
             }
             if (parent is ToggleSwitch toggleSwitch)
             {
                 return ToggleSwitchConverter.MemberHasValue(toggleSwitch, member, value);
             }
             if (parent is Window window)
             {
                 return WindowConverter.MemberHasValue(window, member, value);
             }
             if (parent is PopupRoot popupRoot)
             {
                 return PopupRootConverter.MemberHasValue(popupRoot, member, value);
             }
             if (parent is ButtonSpinner buttonSpinner)
             {
                 return ButtonSpinnerConverter.MemberHasValue(buttonSpinner, member, value);
             }
             if (parent is Carousel carousel)
             {
                 return CarouselConverter.MemberHasValue(carousel, member, value);
             }
             if (parent is ComboBox comboBox)
             {
                 return ComboBoxConverter.MemberHasValue(comboBox, member, value);
             }
             if (parent is ComboBoxItem comboBoxItem)
             {
                 return ComboBoxItemConverter.MemberHasValue(comboBoxItem, member, value);
             }
             if (parent is DropDownButton dropDownButton)
             {
                 return DropDownButtonConverter.MemberHasValue(dropDownButton, member, value);
             }
             if (parent is Expander expander)
             {
                 return ExpanderConverter.MemberHasValue(expander, member, value);
             }
             if (parent is ListBox listBox)
             {
                 return ListBoxConverter.MemberHasValue(listBox, member, value);
             }
             if (parent is MenuBase menuBase)
             {
                 return MenuBaseConverter.MemberHasValue(menuBase, member, value);
             }
             if (parent is RepeatButton repeatButton)
             {
                 return RepeatButtonConverter.MemberHasValue(repeatButton, member, value);
             }
             if (parent is ToggleSplitButton toggleSplitButton)
             {
                 return ToggleSplitButtonConverter.MemberHasValue(toggleSplitButton, member, value);
             }
             if (parent is TabControl tabControl)
             {
                 return TabControlConverter.MemberHasValue(tabControl, member, value);
             }
             if (parent is TabItem tabItem)
             {
                 return TabItemConverter.MemberHasValue(tabItem, member, value);
             }
             if (parent is TreeViewItem treeViewItem)
             {
                 return TreeViewItemConverter.MemberHasValue(treeViewItem, member, value);
             }
             if (parent is WindowBase windowBase)
             {
                 return WindowBaseConverter.MemberHasValue(windowBase, member, value);
             }
             if (parent is EmbeddableControlRoot embeddableControlRoot)
             {
                 return EmbeddableControlRootConverter.MemberHasValue(embeddableControlRoot, member, value);
             }
             if (parent is CalendarButton calendarButton)
             {
                 return CalendarButtonConverter.MemberHasValue(calendarButton, member, value);
             }
             if (parent is CalendarDayButton calendarDayButton)
             {
                 return CalendarDayButtonConverter.MemberHasValue(calendarDayButton, member, value);
             }
             if (parent is HeaderedSelectingItemsControl headeredSelectingItemsControl)
             {
                 return HeaderedSelectingItemsControlConverter.MemberHasValue(headeredSelectingItemsControl, member, value);
             }
             if (parent is TabStrip tabStrip)
             {
                 return TabStripConverter.MemberHasValue(tabStrip, member, value);
             }
             if (parent is TabStripItem tabStripItem)
             {
                 return TabStripItemConverter.MemberHasValue(tabStripItem, member, value);
             }
             if (parent is ToggleButton toggleButton)
             {
                 return ToggleButtonConverter.MemberHasValue(toggleButton, member, value);
             }
             if (parent is ColorSlider colorSlider)
             {
                 return ColorSliderConverter.MemberHasValue(colorSlider, member, value);
             }
             if (parent is Button button)
             {
                 return ButtonConverter.MemberHasValue(button, member, value);
             }
             if (parent is DataValidationErrors dataValidationErrors)
             {
                 return DataValidationErrorsConverter.MemberHasValue(dataValidationErrors, member, value);
             }
             if (parent is DatePickerPresenter datePickerPresenter)
             {
                 return DatePickerPresenterConverter.MemberHasValue(datePickerPresenter, member, value);
             }
             if (parent is TimePickerPresenter timePickerPresenter)
             {
                 return TimePickerPresenterConverter.MemberHasValue(timePickerPresenter, member, value);
             }
             if (parent is FlyoutPresenter flyoutPresenter)
             {
                 return FlyoutPresenterConverter.MemberHasValue(flyoutPresenter, member, value);
             }
             if (parent is GridSplitter gridSplitter)
             {
                 return GridSplitterConverter.MemberHasValue(gridSplitter, member, value);
             }
             if (parent is Label label)
             {
                 return LabelConverter.MemberHasValue(label, member, value);
             }
             if (parent is ListBoxItem listBoxItem)
             {
                 return ListBoxItemConverter.MemberHasValue(listBoxItem, member, value);
             }
             if (parent is MaskedTextBox maskedTextBox)
             {
                 return MaskedTextBoxConverter.MemberHasValue(maskedTextBox, member, value);
             }
             if (parent is ReversibleStackPanel reversibleStackPanel)
             {
                 return ReversibleStackPanelConverter.MemberHasValue(reversibleStackPanel, member, value);
             }
             if (parent is PathIcon pathIcon)
             {
                 return PathIconConverter.MemberHasValue(pathIcon, member, value);
             }
             if (parent is ProgressBar progressBar)
             {
                 return ProgressBarConverter.MemberHasValue(progressBar, member, value);
             }
             if (parent is RefreshContainer refreshContainer)
             {
                 return RefreshContainerConverter.MemberHasValue(refreshContainer, member, value);
             }
             if (parent is RefreshVisualizer refreshVisualizer)
             {
                 return RefreshVisualizerConverter.MemberHasValue(refreshVisualizer, member, value);
             }
             if (parent is ScrollViewer scrollViewer)
             {
                 return ScrollViewerConverter.MemberHasValue(scrollViewer, member, value);
             }
             if (parent is Slider slider)
             {
                 return SliderConverter.MemberHasValue(slider, member, value);
             }
             if (parent is Spinner spinner)
             {
                 return SpinnerConverter.MemberHasValue(spinner, member, value);
             }
             if (parent is SplitButton splitButton)
             {
                 return SplitButtonConverter.MemberHasValue(splitButton, member, value);
             }
             if (parent is SplitView splitView)
             {
                 return SplitViewConverter.MemberHasValue(splitView, member, value);
             }
             if (parent is ToolTip toolTip)
             {
                 return ToolTipConverter.MemberHasValue(toolTip, member, value);
             }
             if (parent is TopLevel topLevel)
             {
                 return TopLevelConverter.MemberHasValue(topLevel, member, value);
             }
             if (parent is TransitioningContentControl transitioningContentControl)
             {
                 return TransitioningContentControlConverter.MemberHasValue(transitioningContentControl, member, value);
             }
             if (parent is TreeView treeView)
             {
                 return TreeViewConverter.MemberHasValue(treeView, member, value);
             }
             if (parent is UserControl userControl)
             {
                 return UserControlConverter.MemberHasValue(userControl, member, value);
             }
             if (parent is VirtualizingCarouselPanel virtualizingCarouselPanel)
             {
                 return VirtualizingCarouselPanelConverter.MemberHasValue(virtualizingCarouselPanel, member, value);
             }
             if (parent is VirtualizingStackPanel virtualizingStackPanel)
             {
                 return VirtualizingStackPanelConverter.MemberHasValue(virtualizingStackPanel, member, value);
             }
             if (parent is NotificationCard notificationCard)
             {
                 return NotificationCardConverter.MemberHasValue(notificationCard, member, value);
             }
             if (parent is AdornerLayer adornerLayer)
             {
                 return AdornerLayerConverter.MemberHasValue(adornerLayer, member, value);
             }
             if (parent is HeaderedContentControl headeredContentControl)
             {
                 return HeaderedContentControlConverter.MemberHasValue(headeredContentControl, member, value);
             }
             if (parent is HeaderedItemsControl headeredItemsControl)
             {
                 return HeaderedItemsControlConverter.MemberHasValue(headeredItemsControl, member, value);
             }
             if (parent is LightDismissOverlayLayer lightDismissOverlayLayer)
             {
                 return LightDismissOverlayLayerConverter.MemberHasValue(lightDismissOverlayLayer, member, value);
             }
             if (parent is OverlayLayer overlayLayer)
             {
                 return OverlayLayerConverter.MemberHasValue(overlayLayer, member, value);
             }
             if (parent is OverlayPopupHost overlayPopupHost)
             {
                 return OverlayPopupHostConverter.MemberHasValue(overlayPopupHost, member, value);
             }
             if (parent is ScrollBar scrollBar)
             {
                 return ScrollBarConverter.MemberHasValue(scrollBar, member, value);
             }
             if (parent is SelectingItemsControl selectingItemsControl)
             {
                 return SelectingItemsControlConverter.MemberHasValue(selectingItemsControl, member, value);
             }
             if (parent is ColorPicker colorPicker)
             {
                 return ColorPickerConverter.MemberHasValue(colorPicker, member, value);
             }
             if (parent is DataGridCell dataGridCell)
             {
                 return DataGridCellConverter.MemberHasValue(dataGridCell, member, value);
             }
             if (parent is DataGridColumnHeader dataGridColumnHeader)
             {
                 return DataGridColumnHeaderConverter.MemberHasValue(dataGridColumnHeader, member, value);
             }
             if (parent is DataGridRowHeader dataGridRowHeader)
             {
                 return DataGridRowHeaderConverter.MemberHasValue(dataGridRowHeader, member, value);
             }
             if (parent is DataGridFrozenGrid dataGridFrozenGrid)
             {
                 return DataGridFrozenGridConverter.MemberHasValue(dataGridFrozenGrid, member, value);
             }
             if (parent is AutoCompleteBox autoCompleteBox)
             {
                 return AutoCompleteBoxConverter.MemberHasValue(autoCompleteBox, member, value);
             }
             if (parent is Border border)
             {
                 return BorderConverter.MemberHasValue(border, member, value);
             }
             if (parent is CalendarDatePicker calendarDatePicker)
             {
                 return CalendarDatePickerConverter.MemberHasValue(calendarDatePicker, member, value);
             }
             if (parent is Calendar calendar)
             {
                 return CalendarConverter.MemberHasValue(calendar, member, value);
             }
             if (parent is Canvas canvas)
             {
                 return CanvasConverter.MemberHasValue(canvas, member, value);
             }
             if (parent is ContentControl contentControl)
             {
                 return ContentControlConverter.MemberHasValue(contentControl, member, value);
             }
             if (parent is DatePicker datePicker)
             {
                 return DatePickerConverter.MemberHasValue(datePicker, member, value);
             }
             if (parent is TimePicker timePicker)
             {
                 return TimePickerConverter.MemberHasValue(timePicker, member, value);
             }
             if (parent is DockPanel dockPanel)
             {
                 return DockPanelConverter.MemberHasValue(dockPanel, member, value);
             }
             if (parent is ExperimentalAcrylicBorder experimentalAcrylicBorder)
             {
                 return ExperimentalAcrylicBorderConverter.MemberHasValue(experimentalAcrylicBorder, member, value);
             }
             if (parent is Grid grid)
             {
                 return GridConverter.MemberHasValue(grid, member, value);
             }
             if (parent is IconElement iconElement)
             {
                 return IconElementConverter.MemberHasValue(iconElement, member, value);
             }
             if (parent is ItemsControl itemsControl)
             {
                 return ItemsControlConverter.MemberHasValue(itemsControl, member, value);
             }
             if (parent is LayoutTransformControl layoutTransformControl)
             {
                 return LayoutTransformControlConverter.MemberHasValue(layoutTransformControl, member, value);
             }
             if (parent is NativeMenuBar nativeMenuBar)
             {
                 return NativeMenuBarConverter.MemberHasValue(nativeMenuBar, member, value);
             }
             if (parent is NumericUpDown numericUpDown)
             {
                 return NumericUpDownConverter.MemberHasValue(numericUpDown, member, value);
             }
             if (parent is RelativePanel relativePanel)
             {
                 return RelativePanelConverter.MemberHasValue(relativePanel, member, value);
             }
             if (parent is SelectableTextBlock selectableTextBlock)
             {
                 return SelectableTextBlockConverter.MemberHasValue(selectableTextBlock, member, value);
             }
             if (parent is Separator separator)
             {
                 return SeparatorConverter.MemberHasValue(separator, member, value);
             }
             if (parent is StackPanel stackPanel)
             {
                 return StackPanelConverter.MemberHasValue(stackPanel, member, value);
             }
             if (parent is TextBox textBox)
             {
                 return TextBoxConverter.MemberHasValue(textBox, member, value);
             }
             if (parent is ThemeVariantScope themeVariantScope)
             {
                 return ThemeVariantScopeConverter.MemberHasValue(themeVariantScope, member, value);
             }
             if (parent is VirtualizingPanel virtualizingPanel)
             {
                 return VirtualizingPanelConverter.MemberHasValue(virtualizingPanel, member, value);
             }
             if (parent is WrapPanel wrapPanel)
             {
                 return WrapPanelConverter.MemberHasValue(wrapPanel, member, value);
             }
             if (parent is Arc arc)
             {
                 return ArcConverter.MemberHasValue(arc, member, value);
             }
             if (parent is Ellipse ellipse)
             {
                 return EllipseConverter.MemberHasValue(ellipse, member, value);
             }
             if (parent is Line line)
             {
                 return LineConverter.MemberHasValue(line, member, value);
             }
             if (parent is Path path)
             {
                 return PathConverter.MemberHasValue(path, member, value);
             }
             if (parent is Polygon polygon)
             {
                 return PolygonConverter.MemberHasValue(polygon, member, value);
             }
             if (parent is Polyline polyline)
             {
                 return PolylineConverter.MemberHasValue(polyline, member, value);
             }
             if (parent is Rectangle rectangle)
             {
                 return RectangleConverter.MemberHasValue(rectangle, member, value);
             }
             if (parent is Sector sector)
             {
                 return SectorConverter.MemberHasValue(sector, member, value);
             }
             if (parent is ScrollContentPresenter scrollContentPresenter)
             {
                 return ScrollContentPresenterConverter.MemberHasValue(scrollContentPresenter, member, value);
             }
             if (parent is WindowNotificationManager windowNotificationManager)
             {
                 return WindowNotificationManagerConverter.MemberHasValue(windowNotificationManager, member, value);
             }
             if (parent is CaptionButtons captionButtons)
             {
                 return CaptionButtonsConverter.MemberHasValue(captionButtons, member, value);
             }
             if (parent is TitleBar titleBar)
             {
                 return TitleBarConverter.MemberHasValue(titleBar, member, value);
             }
             if (parent is CalendarItem calendarItem)
             {
                 return CalendarItemConverter.MemberHasValue(calendarItem, member, value);
             }
             if (parent is DateTimePickerPanel dateTimePickerPanel)
             {
                 return DateTimePickerPanelConverter.MemberHasValue(dateTimePickerPanel, member, value);
             }
             if (parent is PickerPresenterBase pickerPresenterBase)
             {
                 return PickerPresenterBaseConverter.MemberHasValue(pickerPresenterBase, member, value);
             }
             if (parent is AccessText accessText)
             {
                 return AccessTextConverter.MemberHasValue(accessText, member, value);
             }
             if (parent is ChromeOverlayLayer chromeOverlayLayer)
             {
                 return ChromeOverlayLayerConverter.MemberHasValue(chromeOverlayLayer, member, value);
             }
             if (parent is RangeBase rangeBase)
             {
                 return RangeBaseConverter.MemberHasValue(rangeBase, member, value);
             }
             if (parent is Thumb thumb)
             {
                 return ThumbConverter.MemberHasValue(thumb, member, value);
             }
             if (parent is UniformGrid uniformGrid)
             {
                 return UniformGridConverter.MemberHasValue(uniformGrid, member, value);
             }
             if (parent is VisualLayerManager visualLayerManager)
             {
                 return VisualLayerManagerConverter.MemberHasValue(visualLayerManager, member, value);
             }
             if (parent is ColorView colorView)
             {
                 return ColorViewConverter.MemberHasValue(colorView, member, value);
             }
             if (parent is ColorPreviewer colorPreviewer)
             {
                 return ColorPreviewerConverter.MemberHasValue(colorPreviewer, member, value);
             }
             if (parent is ColorSpectrum colorSpectrum)
             {
                 return ColorSpectrumConverter.MemberHasValue(colorSpectrum, member, value);
             }
             if (parent is DataGrid dataGrid)
             {
                 return DataGridConverter.MemberHasValue(dataGrid, member, value);
             }
             if (parent is DataGridRow dataGridRow)
             {
                 return DataGridRowConverter.MemberHasValue(dataGridRow, member, value);
             }
             if (parent is DataGridRowGroupHeader dataGridRowGroupHeader)
             {
                 return DataGridRowGroupHeaderConverter.MemberHasValue(dataGridRowGroupHeader, member, value);
             }
             if (parent is DataGridCellsPresenter dataGridCellsPresenter)
             {
                 return DataGridCellsPresenterConverter.MemberHasValue(dataGridCellsPresenter, member, value);
             }
             if (parent is DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter)
             {
                 return DataGridColumnHeadersPresenterConverter.MemberHasValue(dataGridColumnHeadersPresenter, member, value);
             }
             if (parent is DataGridDetailsPresenter dataGridDetailsPresenter)
             {
                 return DataGridDetailsPresenterConverter.MemberHasValue(dataGridDetailsPresenter, member, value);
             }
             if (parent is DataGridRowsPresenter dataGridRowsPresenter)
             {
                 return DataGridRowsPresenterConverter.MemberHasValue(dataGridRowsPresenter, member, value);
             }
             if (parent is Decorator decorator)
             {
                 return DecoratorConverter.MemberHasValue(decorator, member, value);
             }
             if (parent is Image image)
             {
                 return ImageConverter.MemberHasValue(image, member, value);
             }
             if (parent is NativeControlHost nativeControlHost)
             {
                 return NativeControlHostConverter.MemberHasValue(nativeControlHost, member, value);
             }
             if (parent is Panel panel)
             {
                 return PanelConverter.MemberHasValue(panel, member, value);
             }
             if (parent is TextBlock textBlock)
             {
                 return TextBlockConverter.MemberHasValue(textBlock, member, value);
             }
             if (parent is TickBar tickBar)
             {
                 return TickBarConverter.MemberHasValue(tickBar, member, value);
             }
             if (parent is Viewbox viewbox)
             {
                 return ViewboxConverter.MemberHasValue(viewbox, member, value);
             }
             if (parent is Shape shape)
             {
                 return ShapeConverter.MemberHasValue(shape, member, value);
             }
             if (parent is RemoteWidget remoteWidget)
             {
                 return RemoteWidgetConverter.MemberHasValue(remoteWidget, member, value);
             }
             if (parent is ContentPresenter contentPresenter)
             {
                 return ContentPresenterConverter.MemberHasValue(contentPresenter, member, value);
             }
             if (parent is ItemsPresenter itemsPresenter)
             {
                 return ItemsPresenterConverter.MemberHasValue(itemsPresenter, member, value);
             }
             if (parent is TextPresenter textPresenter)
             {
                 return TextPresenterConverter.MemberHasValue(textPresenter, member, value);
             }
             if (parent is Popup popup)
             {
                 return PopupConverter.MemberHasValue(popup, member, value);
             }
             if (parent is TemplatedControl templatedControl)
             {
                 return TemplatedControlConverter.MemberHasValue(templatedControl, member, value);
             }
             if (parent is Track track)
             {
                 return TrackConverter.MemberHasValue(track, member, value);
             }
             if (parent is Control control)
             {
                 return ControlConverter.MemberHasValue(control, member, value);
             }
             if (parent is InputElement inputElement)
             {
                 return InputElementConverter.MemberHasValue(inputElement, member, value);
             }
             if (parent is Interactive interactive)
             {
                 return InteractiveConverter.MemberHasValue(interactive, member, value);
             }
             if (parent is Layoutable layoutable)
             {
                 return LayoutableConverter.MemberHasValue(layoutable, member, value);
             }

            return VisualConverter.MemberHasValue(visual, member, value);
        }
}
