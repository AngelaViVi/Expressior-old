using CoreNodeModelsWpf.Controls;
using CoreNodeModels.Input;
using Dynamo.Controls;
using Dynamo.Wpf;
using Dynamo.Wpf.Controls;

namespace CoreNodeModelsWpf.NodeViewCustomizations
{
    public class DoubleSliderNodeViewCustomization : INodeViewCustomization<DoubleSlider>
    {
        public void CustomizeView(DoubleSlider model, NodeView nodeView)
        {
            var slider = new DynamoSlider(model, nodeView)
            {
                DataContext = new SliderViewModel<double>(model)
            };

            nodeView.inputGrid.Children.Add(slider);
        }

        public void Dispose()
        {
        }
    }
}