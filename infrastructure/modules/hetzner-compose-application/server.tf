resource "hcloud_ssh_key" "admin_key" {
  name       = "lecture-key"
  public_key = "ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIJTb0amZOk5RWZrW7dJ0+4RLS9jtfhq8bug1ym1kx61o"
}

resource "hcloud_server" "server" {
  name        = "lecture-server"
  server_type = "cax41" # ARM 16vCPU, 32GB RAM, 320 SSD
  image       = "debian-13"
  location    = "hel1" # Helsinki, Finland

  user_data = file("${path.module}/cloud-init.yaml")

  ssh_keys = [
    hcloud_ssh_key.admin_key.id
  ]
}
